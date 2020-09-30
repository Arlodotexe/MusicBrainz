
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;
    public class LifeSpan
    {
        /// <summary>
        /// Creates a new instance of <see cref="LifeSpan"/>.
        /// </summary>
        public LifeSpan()
        {
        }

        /// <summary>
        /// Gets or sets the begin date.
        /// </summary>
        [JsonPropertyName("begin")]
        public string Begin { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        [JsonPropertyName("end")]
        public string End { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the life-span ended or not.
        /// </summary>
        [JsonPropertyName("ended")]
        public bool? Ended { get; set; }
    }
}
