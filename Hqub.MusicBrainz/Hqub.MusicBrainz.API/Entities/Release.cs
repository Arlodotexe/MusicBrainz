
namespace Hqub.MusicBrainz.API.Entities
{
    using Hqub.MusicBrainz.API.Entities.Collections;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    /// <summary>
    /// A MusicBrainz release represents the unique release (i.e. issuing) of a product on a specific
    /// date with specific release information such as the country, label, barcode and packaging.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Release"/>
    public class Release
    {
        /// <summary>
        /// Creates a new instance of <see cref="Release"/>.
        /// </summary>
        public Release()
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
        /// Gets or sets the status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// Gets or sets the text-representation.
        /// </summary>
        [JsonPropertyName("text-representation")]
        public TextRepresentation TextRepresentation { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the barcode.
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or sets the release-group.
        /// </summary>
        [JsonPropertyName("release-group")]
        public ReleaseGroup ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or sets the cover-art-archive.
        /// </summary>
        [JsonPropertyName("cover-art-archive")]
        public CoverArtArchive CoverArtArchive { get; set; }

        #endregion

        #region Subqueries

        /// <summary>
        /// Gets or sets a list of artists associated to this release.
        /// </summary>
        /// <example>
        /// var e = await Release.GetAsync(mbid, "artists");
        /// </example>
        [JsonPropertyName("artist-credit")]
        public List<NameCredit> Credits { get; set; }

        /// <summary>
        /// Gets or sets a list of labels associated to this release.
        /// </summary>
        /// <example>
        /// var e = await Release.GetAsync(mbid, "labels");
        /// </example>
        [JsonPropertyName("label-info")]
        public List<LabelInfo> Labels { get; set; }

        /// <summary>
        /// Gets or sets a list of media/tracks associated to this release.
        /// </summary>
        /// <example>
        /// var e = await Release.GetAsync(mbid, "recordings");
        /// </example>
        [JsonPropertyName("media")]
        public List<Medium> Media { get; set; }

        /// <summary>
        /// Gets or sets a list of relations associated to this release.
        /// </summary>
        /// <example>
        /// var e = await Release.GetAsync(mbid, "url-rels");
        /// </example>
        [JsonPropertyName("relations")]
        public List<Relation> Relations { get; set; }

        #endregion
    }
}
