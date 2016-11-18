// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Value object for schema results.
    /// </summary>
    public partial class SearchSchemaValue
    {
        /// <summary>
        /// Initializes a new instance of the SearchSchemaValue class.
        /// </summary>
        public SearchSchemaValue() { }

        /// <summary>
        /// Initializes a new instance of the SearchSchemaValue class.
        /// </summary>
        /// <param name="indexed">The boolean that indicates the field is
        /// searchable as free text.</param>
        /// <param name="stored">The boolean that indicates whether or not the
        /// field is stored.</param>
        /// <param name="facet">The boolean that indicates whether or not the
        /// field is a facet.</param>
        /// <param name="name">The name.</param>
        /// <param name="displayName">The display name.</param>
        /// <param name="type">The type.</param>
        /// <param name="ownerType">The array of workflows containing the
        /// field.</param>
        public SearchSchemaValue(bool indexed, bool stored, bool facet, string name = default(string), string displayName = default(string), string type = default(string), System.Collections.Generic.IList<string> ownerType = default(System.Collections.Generic.IList<string>))
        {
            Name = name;
            DisplayName = displayName;
            Type = type;
            Indexed = indexed;
            Stored = stored;
            Facet = facet;
            OwnerType = ownerType;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the boolean that indicates the field is searchable as
        /// free text.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "indexed")]
        public bool Indexed { get; set; }

        /// <summary>
        /// Gets or sets the boolean that indicates whether or not the field is
        /// stored.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stored")]
        public bool Stored { get; set; }

        /// <summary>
        /// Gets or sets the boolean that indicates whether or not the field is
        /// a facet.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "facet")]
        public bool Facet { get; set; }

        /// <summary>
        /// Gets or sets the array of workflows containing the field.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ownerType")]
        public System.Collections.Generic.IList<string> OwnerType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
