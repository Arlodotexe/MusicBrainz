namespace Hqub.MusicBrainz.API.Entities
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Disc
    {
        /// <summary>
        /// Creates a new instance of <see cref="Disc"/>.
        /// </summary>
        public Disc()
        {
        }

        /// <summary>
        /// Gets or sets the MusicBrainz id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the number of sectors.
        /// </summary>
        [JsonPropertyName("sectors")]
        public int Sectors { get; set; }

        /// <summary>
        /// Gets or sets the track offsets.
        /// </summary>
        [JsonPropertyName("offsets")]
        public List<int> Offsets { get; set; }
    }
}
