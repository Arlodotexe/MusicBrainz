
namespace Hqub.MusicBrainz.API.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    /// <summary>
    /// In MusicBrainz terminology, a work is a distinct intellectual or artistic creation,
    /// which can be expressed in the form of one or more audio recordings.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Work"/>
    public class Work
    {
        /// <summary>
        /// Creates a new instance of <see cref="Work"/>.
        /// </summary>
        public Work()
        {
        }

        #region Properties

        /// <summary>
        /// Gets or sets the MusicBrainz id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ISW code.
        /// </summary>
        [JsonPropertyName("iswc")]
        public string ISWC { get; set; }

        /// <summary>
        /// Gets or sets the disambiguation.
        /// </summary>
        [JsonPropertyName("disambiguation")]
        public string Disambiguation { get; set; }

        #endregion

        #region Subqueries

        /// <summary>
        /// Gets or sets a list of relations associated to this work.
        /// </summary>
        /// <example>
        /// var e = await Work.GetAsync(mbid, "url-rels");
        /// </example>
        [JsonPropertyName("relations")]
        public List<Relation> Relations { get; set; }

        #endregion
    }
}
