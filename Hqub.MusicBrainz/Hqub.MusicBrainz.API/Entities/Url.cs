
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// A URL in MusicBrainz is a specific entity representing a regular internet Uniform Resource Locator.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/URL"/>
    public class Url
    {
        /// <summary>
        /// Creates a new instance of <see cref="Url"/>.
        /// </summary>
        public Url()
        {
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        [JsonPropertyName("resource")]
        public string Resource { get; set; }
    }
}
