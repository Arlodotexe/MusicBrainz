using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text.Json.Serialization;

namespace Hqub.MusicBrainz.API
{
    /// <summary>
    /// Abstract base class for MusicBrainz queries returning lists (with paging support).
    /// </summary>
    public abstract class QueryResult
    {
        /// <summary>
        /// Gets or sets the total list items count.
        /// </summary>
        /// <remarks>
        /// This might be different form the actual list items count. If the list was
        /// generated from a search request, this property will return the total number
        /// of available items (on the server), while the number of returned items is
        /// limited by the requests 'limit' parameter (default = 25).
        /// </remarks>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list offset (only available in search requests).
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }
    }
}
