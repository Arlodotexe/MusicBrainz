
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Label information.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Label"/>
    public class Label
    {
        /// <summary>
        /// Creates a new instance of <see cref="Label"/>.
        /// </summary>
        public Label()
        {
        }

        /// <summary>
        /// Gets or sets the MusicBrainz id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the disambiguation.
        /// </summary>
        [JsonPropertyName("disambiguation")]
        public string Disambiguation { get; set; }
    }
}
