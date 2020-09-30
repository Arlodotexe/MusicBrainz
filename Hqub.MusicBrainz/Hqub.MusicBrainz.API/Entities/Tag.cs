
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;
    public class Tag
    {
        /// <summary>
        /// Creates a new instance of <see cref="Tag"/>.
        /// </summary>
        public Tag()
        {
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
