
namespace Hqub.MusicBrainz.API.Entities.Collections
{
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    /// <summary>
    /// List of artists returned by MusicBrainz search requests.
    /// </summary>
    public class ArtistList : QueryResult
    {
        /// <summary>
        /// Creates a new instance of <see cref="ArtistList"/>.
        /// </summary>
        public ArtistList()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("artists")]
        public List<Artist> Items { get; set; }
    }

    // NOTE: for MusicBrainz ws/3 this additional class might no longer be necessary.
    //       See https://tickets.metabrainz.org/browse/MBS-9731

    /// <summary>
    /// List of artists returned by MusicBrainz browse requests.
    /// </summary>
    internal class ArtistListBrowse
    {
        /// <summary>
        /// Creates a new instance of <see cref="ArtistListBrowse"/>.
        /// </summary>
        public ArtistListBrowse()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("artists")]
        public List<Artist> Items { get; set; }

        // NOTE: hide members of the base class to make serialization work

        /// <summary>
        /// Gets or sets the total list items count.
        /// </summary>
        [JsonPropertyName("artist-count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list offset.
        /// </summary>
        [JsonPropertyName("artist-offset")]
        public int Offset { get; set; }
    }
}
