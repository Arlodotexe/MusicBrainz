
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Physical representation of a release.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Medium"/>
    public class Medium
    {
        /// <summary>
        /// Creates a new instance of <see cref="Medium"/>.
        /// </summary>
        public Medium()
        {
        }

        /// <summary>
        /// Gets or sets the number of tracks.
        /// </summary>
        [JsonPropertyName("track-count")]
        public int TrackCount { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the disc list.
        /// </summary>
        [JsonPropertyName("discs")]
        public List<Disc> Discs { get; set; }

        /// <summary>
        /// Gets or sets the track list.
        /// </summary>
        [JsonPropertyName("tracks")]
        public List<Track> Tracks { get; set; }
    }
}
