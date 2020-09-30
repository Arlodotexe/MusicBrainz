
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A recording is an entity in MusicBrainz which can be linked to tracks on releases. Each track must always
    /// be associated with a single recording, but a recording can be linked to any number of tracks. 
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Recording"/>
    public class Recording
    {
        /// <summary>
        /// Creates an instance of <see cref="Recording"/>.
        /// </summary>
        public Recording()
        {
        }

        #region Properties

        /// <summary>
        /// Gets or sets the score (only available in search results).
        /// </summary>
        [JsonPropertyName("score")]
        public int Score { get; set; }

        /// <summary>
        /// Gets or sets the MusicBrainz id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        [JsonPropertyName("length")]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the disambiguation.
        /// </summary>
        [JsonPropertyName("disambiguation")]
        public string Disambiguation { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [JsonPropertyName("rating")]
        public Rating Rating { get; set; }

        #endregion

        #region Subqueries

        /// <summary>
        /// Gets or sets a list of artists associated to this recording.
        /// </summary>
        /// <example>
        /// var e = await Recording.GetAsync(mbid, "artists");
        /// </example>
        [JsonPropertyName("artist-credit")]
        public List<NameCredit> Credits { get; set; }

        /// <summary>
        /// Gets or sets a list of releases associated to this recording.
        /// </summary>
        /// <example>
        /// var e = await Recording.GetAsync(mbid, "releases");
        /// </example>
        [JsonPropertyName("releases")]
        public List<Release> Releases { get; set; }

        /// <summary>
        /// Gets or sets a list of tags associated to this recording.
        /// </summary>
        /// <example>
        /// var e = await Recording.GetAsync(mbid, "tags");
        /// </example>
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets a list of relations associated to this recording.
        /// </summary>
        /// <example>
        /// var e = await Recording.GetAsync(mbid, "url-rels");
        /// </example>
        [JsonPropertyName("relations")]
        public List<Relation> Relations { get; set; }

        #endregion
    }
}
