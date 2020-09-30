
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    /// <summary>
    /// An artist is generally a musician (or musician persona), group of musicians
    /// or other music professional (like a producer or engineer).
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Artist"/>
    public partial class Artist
    {
        /// <summary>
        /// Creates a new instance of <see cref="Artist"/>.
        /// </summary>
        public Artist()
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
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sort name.
        /// </summary>
        [JsonPropertyName("sort-name")]
        public string SortName { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the life-span.
        /// </summary>
        [JsonPropertyName("life-span")]
        public LifeSpan LifeSpan { get; set; }

        /// <summary>
        /// Gets or sets the area.
        /// </summary>
        [JsonPropertyName("area")]
        public Area Area { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

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
        /// Gets or sets a list of recordings associated to this artist.
        /// </summary>
        /// <example>
        /// var e = await Artist.GetAsync(mbid, "recordings");
        /// </example>
        [JsonPropertyName("recordings")]
        public List<Recording> Recordings { get; set; }

        /// <summary>
        /// Gets or sets a list of release-groups associated to this artist.
        /// </summary>
        /// <example>
        /// var e = await Artist.GetAsync(mbid, "release-groups");
        /// </example>
        [JsonPropertyName("release-groups")]
        public List<ReleaseGroup> ReleaseGroups { get; set; }

        /// <summary>
        /// Gets or sets a list of releases associated to this artist.
        /// </summary>
        /// <example>
        /// var e = await Artist.GetAsync(mbid, "releases");
        /// </example>
        [JsonPropertyName("releases")]
        public List<Release> Releases { get; set; }

        /// <summary>
        /// Gets or sets a list of works associated to this artist.
        /// </summary>
        /// <example>
        /// var e = await Artist.GetAsync(mbid, "works");
        /// </example>
        [JsonPropertyName("works")]
        public List<Work> Works { get; set; }

        /// <summary>
        /// Gets or sets a list of tags associated to this artist.
        /// </summary>
        /// <example>
        /// var e = await Artist.GetAsync(mbid, "tags");
        /// </example>
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets a list of relations associated to this artist.
        /// </summary>
        /// <example>
        /// var e = await Artist.GetAsync(mbid, "url-rels", "artist-rels");
        /// </example>
        [JsonPropertyName("relations")]
        public List<Relation> Relations { get; set; }

        #endregion
    }
}
