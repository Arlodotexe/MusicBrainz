
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Areas are geographic regions or settlements.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Area"/>
    public class Area
    {
        /// <summary>
        /// Creates a new instance of <see cref="Area"/>.
        /// </summary>
        public Area()
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
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the disambiguation.
        /// </summary>
        [JsonPropertyName("disambiguation")]
        public string Disambiguation { get; set; }

        /// <summary>
        /// Gets or sets the iso-3166-1 codes.
        /// </summary>
        [JsonPropertyName("iso-3166-1-codes")]
        public List<string> IsoCodes { get; set; }
    }
}
