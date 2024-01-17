//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A flexible way to unambiguously specify a function. Instance ID is preferred, then model output, then function ID.</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class FunctionIdentifier 
    {
        [JsonConstructor]
        public FunctionIdentifier(string @instanceId, string @modelOutput, string @functionId)
        {
            this.InstanceId = @instanceId;
            this.ModelOutput = @modelOutput;
            this.FunctionId = @functionId;
            }
        
        
        // Empty constructor
        public FunctionIdentifier()
        {
        }
    
        [JsonProperty("instanceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstanceId { get; set; }
    
        [JsonProperty("modelOutput", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModelOutput { get; set; }
    
        [JsonProperty("functionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FunctionId { get; set; }
    
    
    }
}