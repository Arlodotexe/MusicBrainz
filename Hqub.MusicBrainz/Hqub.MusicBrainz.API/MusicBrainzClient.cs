using System.Text.Json;
using ComposableAsync;
using RateLimiter;

namespace Hqub.MusicBrainz.API
{
    using Cache;
    using Services;
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// MusicBrainz client.
    /// </summary>
    public sealed class MusicBrainzClient : IDisposable
    {
        /// <summary>
        /// The default address of the MusicBrainz webservice.
        /// </summary>
        public const string ServiceBaseAddress = "https://musicbrainz.org/ws/2/";

        private const string UserAgent = "Hqub.MusicBrainz/3.0-beta";

        #region Public services

        /// <summary>
        /// Gets the artists entity service.
        /// </summary>
        public IArtistService Artists { get; }

        /// <summary>
        /// Gets the recordings entity service.
        /// </summary>
        public IRecordingService Recordings { get; }

        /// <summary>
        /// Gets the releases entity service.
        /// </summary>
        public IReleaseService Releases { get; }

        /// <summary>
        /// Gets the release-groups entity service.
        /// </summary>
        public IReleaseGroupService ReleaseGroups { get; }

        /// <summary>
        /// Gets the work entity service.
        /// </summary>
        public IWorkService Work { get; }

        #endregion

        /// <summary>
        /// Gets or sets the <see cref="IRequestCache"/> implementation.
        /// </summary>
        public IRequestCache Cache { get; set; }

        private readonly HttpClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicBrainzClient"/> class.
        /// </summary>
        public MusicBrainzClient()
            : this(ServiceBaseAddress)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicBrainzClient"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address of the webservice (default = <see cref="ServiceBaseAddress"/>).</param>
        public MusicBrainzClient(string baseAddress)
        {
            var urlBuilder = new UrlBuilder(true);

            Artists = new ArtistService(this, urlBuilder);
            Recordings = new RecordingService(this, urlBuilder);
            Releases = new ReleaseService(this, urlBuilder);
            ReleaseGroups = new ReleaseGroupService(this, urlBuilder);
            Work = new WorkService(this, urlBuilder);

            client = CreateHttpClient(new Uri(baseAddress), false);
        }

        /// <summary>
        /// Disposes the HTTP client.
        /// </summary>
        public void Dispose()
        {
            client.Dispose();
        }

        [DataContract]
        class ResponseError
        {
            [DataMember(Name = "error")]
            public string Message;
        }

        internal async Task<T> GetAsync<T>(string url)
        {
            var cache = Cache ?? NullCache.Default;

            Stream stream;

            try
            {
                if (await cache.TryGetCachedItem(url, out stream).ConfigureAwait(false))
                {
                    var result = await JsonSerializer.DeserializeAsync<T>(stream, new JsonSerializerOptions());

                    // TODO: if de-serialization of the cache file fails, we shouldn't throw 
                    //       but delete the file and go on with calling the webservice!

                    stream.Close();

                    return result;
                }
            }
            catch
            {
                // ignore
            }

            using (var response = await client.GetAsync(url).ConfigureAwait(false))
            {
                stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    throw CreateWebserviceException(response.StatusCode, url, stream);
                }

                await cache.Add(url, stream).ConfigureAwait(false);

                var result = await JsonSerializer.DeserializeAsync<T>(stream);

                stream.Close();
                return result;
            }
        }

        private WebServiceException CreateWebserviceException(HttpStatusCode status, string url, Stream stream)
        {
            var serializer = new DataContractJsonSerializer(typeof(ResponseError));

            var error = (ResponseError)serializer.ReadObject(stream);

            return new WebServiceException(error.Message, status, url);
        }

        private HttpClient CreateHttpClient(Uri baseAddress, bool automaticDecompression)
        {
            var handler = TimeLimiter
                .GetFromMaxCountByInterval(300, TimeSpan.FromSeconds(1))
                .AsDelegatingHandler();

            // proxy support removed, not supported by handler created by RateLimiter lib

            if (automaticDecompression)
            {
                // Disabled. Not supported in Mono.
                // handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }

            var client = new HttpClient(handler);

            client.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            client.BaseAddress = baseAddress;

            return client;
        }
    }
}
