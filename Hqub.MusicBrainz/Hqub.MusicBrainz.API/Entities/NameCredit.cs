
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Artist credits indicate who is the main credited artist (or artists) for releases, release groups, tracks and recordings.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Artist_Credits"/>
    public class NameCredit
    {
        /// <summary>
        /// Creates a new instance of <see cref="NameCredit"/>.
        /// </summary>
        public NameCredit()
        {
        }

        /// <summary>
        /// Gets or sets the joinphrase.
        /// </summary>
        [JsonPropertyName("joinphrase")]
        public string JoinPhrase { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the artist.
        /// </summary>
        [JsonPropertyName("artist")]
        public Artist Artist { get; set; }
    }
}