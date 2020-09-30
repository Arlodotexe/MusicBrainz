
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;
    public class LabelInfo
    {
        /// <summary>
        /// Creates a new instance of <see cref="LabelInfo"/>.
        /// </summary>
        public LabelInfo()
        {
        }

        /// <summary>
        /// Gets or sets the catalog-number.
        /// </summary>
        [JsonPropertyName("catalog-number")]
        public string CatalogNumber { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [JsonPropertyName("label")]
        public Label Label { get; set; }
    }
}
