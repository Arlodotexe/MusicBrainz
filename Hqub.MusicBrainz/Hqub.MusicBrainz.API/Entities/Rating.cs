
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Rating information.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Rating_System"/>
    public class Rating
    {
        /// <summary>
        /// Creates a new instance of <see cref="Rating"/>.
        /// </summary>
        public Rating()
        {
        }

        /// <summary>
        /// Gets or sets the votes-count.
        /// </summary>
        [JsonPropertyName("votes-count")]
        public int VotesCount { get; set; }

        /// <summary>
        /// Gets or sets the rating value.
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}
