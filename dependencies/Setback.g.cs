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

    /// <summary>Represents a site setback or stepback which limits a building's massing. </summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Setback : GeometricElement
    {
        [JsonConstructor]
        public Setback(Line @baseline, double @distance, double @startingHeight, System.Guid @site, double @angle, double? @balconyProtrusionDepth, Transform @transform = null, Material @material = null, Representation @representation = null, bool @isElementDefinition = false, System.Guid @id = default, string @name = null)
            : base(transform, material, representation, isElementDefinition, id, name)
        {
            this.Baseline = @baseline;
            this.Distance = @distance;
            this.StartingHeight = @startingHeight;
            this.Site = @site;
            this.Angle = @angle;
            this.BalconyProtrusionDepth = @balconyProtrusionDepth;
            }
        
        
        // Empty constructor
        public Setback()
            : base()
        {
        }
    
        /// <summary>The line from which this setback is measured, often the edge of a parcel.</summary>
        [JsonProperty("Baseline", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Line Baseline { get; set; }
    
        /// <summary>The setback distance.</summary>
        [JsonProperty("Distance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Distance { get; set; }
    
        /// <summary>The elevation above which the setback takes effect.</summary>
        [JsonProperty("Starting Height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double StartingHeight { get; set; }
    
        /// <summary>The ID of the site this setback is associated with</summary>
        [JsonProperty("Site", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Site { get; set; }
    
        /// <summary>The angle of the setback or skyplane. An angle of 0.0 is a vertical setback.</summary>
        [JsonProperty("Angle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Angle { get; set; }
    
        /// <summary>If set, balconies are permitted to penetrate into this setback by this distance.</summary>
        [JsonProperty("Balcony Protrusion Depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BalconyProtrusionDepth { get; set; } = 0D;
    
    
    }
}