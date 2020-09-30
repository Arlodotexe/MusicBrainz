
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;
    public class TextRepresentation
    {
        /// <summary>
        /// Creates a new instance of <see cref="TextRepresentation"/>.
        /// </summary>
        public TextRepresentation()
        {
        }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the script.
        /// </summary>
        [JsonPropertyName("script")]
        public string Script { get; set; }
    }
}
