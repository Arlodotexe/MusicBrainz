
namespace Hqub.MusicBrainz.API.Entities.Collections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// List of release-groups returned by MusicBrainz search requests.
    /// </summary>
    public class ReleaseGroupList : QueryResult
    {
        /// <summary>
        /// Creates a new instance of <see cref="ReleaseGroupList"/>.
        /// </summary>
        public ReleaseGroupList()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("release-groups")]
        public List<ReleaseGroup> Items { get; set; }
    }

    // NOTE: for MusicBrainz ws/3 this additional class might no longer be necessary.
    //       See https://tickets.metabrainz.org/browse/MBS-9731

    /// <summary>
    /// List of release-groups returned by MusicBrainz browse requests.
    /// </summary>
    internal class ReleaseGroupListBrowse
    {
        /// <summary>
        /// Creates a new instance of <see cref="ReleaseGroupReleaseGroupListBrowseList"/>.
        /// </summary>
        public ReleaseGroupListBrowse()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("release-groups")]
        public List<ReleaseGroup> Items { get; set; }

        // NOTE: hide members of the base class to make serialization work

        /// <summary>
        /// Gets or sets the total list items count.
        /// </summary>
        [JsonPropertyName("release-group-count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list offset.
        /// </summary>
        [JsonPropertyName("release-group-offset")]
        public int Offset { get; set; }
    }
}
