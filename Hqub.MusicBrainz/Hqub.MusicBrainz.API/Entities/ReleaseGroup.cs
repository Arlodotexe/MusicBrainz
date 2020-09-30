
namespace Hqub.MusicBrainz.API.Entities
{
    using Hqub.MusicBrainz.API.Entities.Collections;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    /// <summary>
    /// A release group is used to group several different releases into a single logical entity.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Release_Group"/>
    public class ReleaseGroup
    {
        /// <summary>
        /// Creates a new instance of <see cref="ReleaseGroup"/>.
        /// </summary>
        public ReleaseGroup()
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
        /// Gets or sets the first release date.
        /// </summary>
        [JsonPropertyName("first-release-date")]
        public string FirstReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the primary type.
        /// </summary>
        [JsonPropertyName("primary-type")]
        public string PrimaryType { get; set; }

        /// <summary>
        /// Gets or sets the secondary types.
        /// </summary>
        [JsonPropertyName("secondary-types")]
        public List<string> SecondaryTypes { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [JsonPropertyName("rating")]
        public Rating Rating { get; set; }

        #endregion

        #region Subqueries

        /// <summary>
        /// Gets or sets a list of artists associated to this release-group.
        /// </summary>
        /// <example>
        /// var e = await ReleaseGroup.GetAsync(mbid, "artists");
        /// </example>
        [JsonPropertyName("artist-credit")]
        public List<NameCredit> Credits { get; set; }

        /// <summary>
        /// Gets or sets a list of releases associated to this release-group.
        /// </summary>
        /// <example>
        /// var e = await ReleaseGroup.GetAsync(mbid, "releases");
        /// </example>
        [JsonPropertyName("releases")]
        public List<Release> Releases { get; set; }

        /// <summary>
        /// Gets or sets a list of tags associated to this release-group.
        /// </summary>
        /// <example>
        /// var e = await ReleaseGroup.GetAsync(mbid, "tags");
        /// </example>
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets a list of relations associated to this release-group.
        /// </summary>
        /// <example>
        /// var e = await ReleaseGroup.GetAsync(mbid, "url-rels");
        /// </example>
        [JsonPropertyName("relations")]
        public List<Relation> Relations { get; set; }

        #endregion
    }
}
