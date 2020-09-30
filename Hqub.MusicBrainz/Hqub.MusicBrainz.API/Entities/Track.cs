
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// In MusicBrainz, a track is the way a recording is represented on a particular
    /// release (or, more exactly, on a particular medium).
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Track"/>
    public class Track
    {
        /// <summary>
        /// Creates a new instance of <see cref="Track"/>.
        /// </summary>
        public Track()
        {
        }

        /// <summary>
        /// Gets or sets the MusicBrainz id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [JsonPropertyName("position")]
        public int Position { get; set; }
        
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        [JsonPropertyName("length")]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the recording.
        /// </summary>
        [JsonPropertyName("recording")]
        public Recording Recording { get; set; }

    }
}
