namespace Hqub.MusicBrainz.API.Entities.Collections
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// List of recordings returned by MusicBrainz search requests.
    /// </summary>
    public class RecordingList : QueryResult
    {
        /// <summary>
        /// Creates a new instance of <see cref="RecordingList"/>.
        /// </summary>
        public RecordingList()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("recordings")]
        public List<Recording> Items { get; set; }
    }

    // NOTE: for MusicBrainz ws/3 this additional class might no longer be necessary.
    //       See https://tickets.metabrainz.org/browse/MBS-9731

    /// <summary>
    /// List of recordings returned by MusicBrainz browse requests.
    /// </summary>
    internal class RecordingListBrowse
    {
        /// <summary>
        /// Creates a new instance of <see cref="RecordingListBrowse"/>.
        /// </summary>
        public RecordingListBrowse()
        {
        }

        /// <summary>
        /// Gets or sets the list of artists.
        /// </summary>
        [JsonPropertyName("recordings")]
        public List<Recording> Items { get; set; }

        // NOTE: hide members of the base class to make serialization work

        /// <summary>
        /// Gets or sets the total list items count.
        /// </summary>
        [JsonPropertyName("recording-count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list offset.
        /// </summary>
        [JsonPropertyName("recording-offset")]
        public int Offset { get; set; }
    }
}
