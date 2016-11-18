// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Metadata for search results.
    /// </summary>
    public partial class SearchMetadata
    {
        /// <summary>
        /// Initializes a new instance of the SearchMetadata class.
        /// </summary>
        public SearchMetadata() { }

        /// <summary>
        /// Initializes a new instance of the SearchMetadata class.
        /// </summary>
        /// <param name="searchId">The request id of the search.</param>
        /// <param name="resultType">The search result type.</param>
        /// <param name="total">The total search results.</param>
        /// <param name="top">The number of top search results.</param>
        /// <param name="id">The id of the search results request.</param>
        /// <param name="coreSummaries">The core summaries.</param>
        /// <param name="status">The status of the search results.</param>
        /// <param name="startTime">The start time for the search.</param>
        /// <param name="lastUpdated">The time of last update.</param>
        /// <param name="eTag">The ETag of the search results.</param>
        /// <param name="sort">Gets or sets sort.</param>
        /// <param name="requestTime">The request time.</param>
        /// <param name="aggregatedValueField">The aggregated value
        /// field.</param>
        /// <param name="aggregatedGroupingFields">The aggregated grouping
        /// fields.</param>
        /// <param name="sum">The sum.</param>
        /// <param name="max">The max.</param>
        /// <param name="schema">The schema.</param>
        public SearchMetadata(string searchId = default(string), string resultType = default(string), long? total = default(long?), long? top = default(long?), string id = default(string), System.Collections.Generic.IList<CoreSummary> coreSummaries = default(System.Collections.Generic.IList<CoreSummary>), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? lastUpdated = default(System.DateTime?), string eTag = default(string), System.Collections.Generic.IList<SearchSort> sort = default(System.Collections.Generic.IList<SearchSort>), long? requestTime = default(long?), string aggregatedValueField = default(string), string aggregatedGroupingFields = default(string), long? sum = default(long?), long? max = default(long?), SearchMetadataSchema schema = default(SearchMetadataSchema))
        {
            SearchId = searchId;
            ResultType = resultType;
            Total = total;
            Top = top;
            Id = id;
            CoreSummaries = coreSummaries;
            Status = status;
            StartTime = startTime;
            LastUpdated = lastUpdated;
            ETag = eTag;
            Sort = sort;
            RequestTime = requestTime;
            AggregatedValueField = aggregatedValueField;
            AggregatedGroupingFields = aggregatedGroupingFields;
            Sum = sum;
            Max = max;
            Schema = schema;
        }

        /// <summary>
        /// Gets or sets the request id of the search.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "RequestId")]
        public string SearchId { get; set; }

        /// <summary>
        /// Gets or sets the search result type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resultType")]
        public string ResultType { get; set; }

        /// <summary>
        /// Gets or sets the total search results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// Gets or sets the number of top search results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "top")]
        public long? Top { get; set; }

        /// <summary>
        /// Gets or sets the id of the search results request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the core summaries.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "CoreSummaries")]
        public System.Collections.Generic.IList<CoreSummary> CoreSummaries { get; set; }

        /// <summary>
        /// Gets or sets the status of the search results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the start time for the search.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "StartTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time of last update.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "LastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the search results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets sort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sort")]
        public System.Collections.Generic.IList<SearchSort> Sort { get; set; }

        /// <summary>
        /// Gets or sets the request time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "requestTime")]
        public long? RequestTime { get; set; }

        /// <summary>
        /// Gets or sets the aggregated value field.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "aggregatedValueField")]
        public string AggregatedValueField { get; set; }

        /// <summary>
        /// Gets or sets the aggregated grouping fields.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "aggregatedGroupingFields")]
        public string AggregatedGroupingFields { get; set; }

        /// <summary>
        /// Gets or sets the sum.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sum")]
        public long? Sum { get; set; }

        /// <summary>
        /// Gets or sets the max.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "max")]
        public long? Max { get; set; }

        /// <summary>
        /// Gets or sets the schema.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schema")]
        public SearchMetadataSchema Schema { get; set; }

    }
}
