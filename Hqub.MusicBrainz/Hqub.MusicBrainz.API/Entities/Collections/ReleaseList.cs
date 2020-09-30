
namespace Hqub.MusicBrainz.API.Entities.Collections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// List of releases returned by MusicBrainz search requests.
    /// </summary>
    public class ReleaseList : QueryResult
    {
        /// <summary>
        /// Creates a new instance of <see cref="ReleaseList"/>.
        /// </summary>
        public ReleaseList()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("releases")]
        public List<Release> Items { get; set; }
    }

    // NOTE: for MusicBrainz ws/3 this additional class might no longer be necessary.
    //       See https://tickets.metabrainz.org/browse/MBS-9731

    /// <summary>
    /// List of releases returned by MusicBrainz browse requests.
    /// </summary>
    internal class ReleaseListBrowse
    {
        /// <summary>
        /// Creates a new instance of <see cref="ReleaseListBrowse"/>.
        /// </summary>
        public ReleaseListBrowse()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("releases")]
        public List<Release> Items { get; set; }

        /// <summary>
        /// Gets or sets the total list items count.
        /// </summary>
        [JsonPropertyName("release-count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list offset.
        /// </summary>
        [JsonPropertyName("release-offset")]
        public int Offset { get; set; }
    }
}
