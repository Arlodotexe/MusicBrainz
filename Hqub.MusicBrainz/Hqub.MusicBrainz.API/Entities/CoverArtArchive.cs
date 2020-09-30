using System;
using System.Text.Json.Serialization;

namespace Hqub.MusicBrainz.API.Entities
{
    /// <summary>
    /// Cover Art Archive information.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Cover_Art_Archive"/>
    public class CoverArtArchive
    {
        /// <summary>
        /// Creates a new instance of <see cref="CoverArtArchive"/>.
        /// </summary>
        public CoverArtArchive()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether artwork is available or not.
        /// </summary>
        [JsonPropertyName("artwork")]
        public bool Artwork { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a front crover is available or not.
        /// </summary>
        [JsonPropertyName("front")]
        public bool Front { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a back crover is available or not.
        /// </summary>
        [JsonPropertyName("back")]
        public bool Back { get; set; }

        public static Uri GetCoverArtUri(string releaseId)
        {
            string url = "https://coverartarchive.org/release/" + releaseId + "/front-250.jpg";
            return new Uri(url, UriKind.RelativeOrAbsolute);
        }
    }
}
