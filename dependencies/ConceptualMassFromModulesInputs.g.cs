// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace ConceptualMassFromModules
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public  class ConceptualMassFromModulesInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public ConceptualMassFromModulesInputs(Overrides @overrides, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<ConceptualMassFromModulesInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @overrides});
            }
        
            this.Overrides = @overrides ?? this.Overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; } = new Overrides();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class Overrides 
    
    {
        public Overrides() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(IList<MassingStrategySettingsOverride> @massingStrategySettings, IList<BuildingInfoOverride> @buildingInfo, IList<LevelSettingsOverride> @levelSettings)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @massingStrategySettings, @buildingInfo, @levelSettings});
            }
        
            this.MassingStrategySettings = @massingStrategySettings ?? this.MassingStrategySettings;
            this.BuildingInfo = @buildingInfo ?? this.BuildingInfo;
            this.LevelSettings = @levelSettings ?? this.LevelSettings;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Massing Strategy Settings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<MassingStrategySettingsOverride> MassingStrategySettings { get; set; } = new List<MassingStrategySettingsOverride>();
    
        [Newtonsoft.Json.JsonProperty("Building Info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<BuildingInfoOverride> BuildingInfo { get; set; } = new List<BuildingInfoOverride>();
    
        [Newtonsoft.Json.JsonProperty("Level Settings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<LevelSettingsOverride> LevelSettings { get; set; } = new List<LevelSettingsOverride>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassingStrategySettingsOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassingStrategySettingsOverride(string @id, MassingStrategySettingsIdentity @identity, MassingStrategySettingsValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassingStrategySettingsOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassingStrategySettingsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MassingStrategySettingsValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BuildingInfoOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BuildingInfoOverride(string @id, BuildingInfoIdentity @identity, BuildingInfoValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BuildingInfoOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildingInfoIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BuildingInfoValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class LevelSettingsOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public LevelSettingsOverride(string @id, LevelSettingsIdentity @identity, LevelSettingsValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<LevelSettingsOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LevelSettingsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LevelSettingsValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassingStrategySettingsIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassingStrategySettingsIdentity(string @addId)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassingStrategySettingsIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @addId});
            }
        
            this.AddId = @addId;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Add Id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddId { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class MassingStrategySettingsValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public MassingStrategySettingsValue(double? @barWidth, IList<Line> @skeleton)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<MassingStrategySettingsValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @barWidth, @skeleton});
            }
        
            this.BarWidth = @barWidth;
            this.Skeleton = @skeleton;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Bar Width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BarWidth { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Skeleton", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<Line> Skeleton { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BuildingInfoIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BuildingInfoIdentity(IList<string> @massAddIds)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BuildingInfoIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @massAddIds});
            }
        
            this.MassAddIds = @massAddIds;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("MassAddIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<string> MassAddIds { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class BuildingInfoValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public BuildingInfoValue(string @name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<BuildingInfoValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name});
            }
        
            this.Name = @name;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class LevelSettingsIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public LevelSettingsIdentity(string @addId)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<LevelSettingsIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @addId});
            }
        
            this.AddId = @addId;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Add Id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddId { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class LevelSettingsValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public LevelSettingsValue(string @primaryUseCategory)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<LevelSettingsValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @primaryUseCategory});
            }
        
            this.PrimaryUseCategory = @primaryUseCategory;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>What is the primary use for this level? This can differ from the primary use of the mass overall.</summary>
        [Newtonsoft.Json.JsonProperty("Primary Use Category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrimaryUseCategory { get; set; }
    
    }
}