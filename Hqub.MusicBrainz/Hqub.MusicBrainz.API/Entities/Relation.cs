
namespace Hqub.MusicBrainz.API.Entities
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// Relationships are a way to represent all the different ways in which entities are connected
    /// to each other and to URLs outside MusicBrainz.
    /// </summary>
    /// <see href="https://musicbrainz.org/doc/Relationships"/>
    public class Relation
    {
        #region Properties

        /// <summary>
        /// Gets or sets the relation type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the relation type ID.
        /// </summary>
        [JsonPropertyName("type-id")]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or sets the relation target type.
        /// </summary>
        [JsonPropertyName("target-type")]
        public string TargetType { get; set; }

        /// <summary>
        /// Gets or sets the relation direction.
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

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
        /// Gets or sets a value indicating whether the relation ended or not.
        /// </summary>
        [JsonPropertyName("ended")]
        public bool? Ended { get; set; }

        /// <summary>
        /// Gets or sets a list of attributes.
        /// </summary>
        [JsonPropertyName("attributes")]
        public string[] Attributes { get; set; }

        #endregion

        #region Relations

        // NOTE: using derived classes and the KnownTypes attribute does not work,
        //       so we add the relations explicitly.

        /// <summary>
        /// Gets or sets the url relationship (include url-rels).
        /// </summary>
        [JsonPropertyName("url")]
        public Url Url { get; set; }

        /// <summary>
        /// Gets or sets the artist relationship (include artist-rels).
        /// </summary>
        [JsonPropertyName("artist")]
        public Artist Artist { get; set; }

        /// <summary>
        /// Gets or sets the work relationship (include work-rels).
        /// </summary>
        [JsonPropertyName("work")]
        public Work Work { get; set; }

        // Other relationships:
        //
        //   /// <summary>
        //   /// Gets or sets the release relationship (include release-rels).
        //   /// </summary>
        //   [JsonPropertyName("release")]
        //   public Release Release { get; set; }
        //

        #endregion
    }
}
