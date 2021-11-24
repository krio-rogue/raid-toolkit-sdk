//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.7.0.0 (NJsonSchema v10.1.24.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

using System.Collections.Generic;
using Raid.DataModel.Enums;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace RaidExtractor.Core
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AccountDump
    {
        [Newtonsoft.Json.JsonProperty("fileVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileVersion { get; set; } = "1.1";

        [Newtonsoft.Json.JsonProperty("artifacts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Artifact> Artifacts { get; set; }

        [Newtonsoft.Json.JsonProperty("heroes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Hero> Heroes { get; set; }

        [Newtonsoft.Json.JsonProperty("arenaLeague", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ArenaLeague { get; set; }

        [Newtonsoft.Json.JsonProperty("greatHall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, int>> GreatHall { get; set; }

        [Newtonsoft.Json.JsonProperty("factionGuardians", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, int>> FactionGuardians { get; set; }

        [Newtonsoft.Json.JsonProperty("shards", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IReadOnlyDictionary<string, ShardInfo> Shards { get; set; }

        [Newtonsoft.Json.JsonProperty("stagePresets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IReadOnlyDictionary<int, int[]> StagePresets { get; set; }

        [Newtonsoft.Json.JsonProperty("lastUpdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastUpdated { get; set; }
    }


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Artifact
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("sellPrice", Required = Newtonsoft.Json.Required.Always)]
        public int SellPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Always)]
        public int Price { get; set; }

        [Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.Always)]
        public int Level { get; set; }

        [Newtonsoft.Json.JsonProperty("isActivated", Required = Newtonsoft.Json.Required.Always)]
        public bool IsActivated { get; set; }

        [Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kind { get; set; }

        [Newtonsoft.Json.JsonProperty("rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Rank { get; set; }

        [Newtonsoft.Json.JsonProperty("rarity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Rarity { get; set; }

        [Newtonsoft.Json.JsonProperty("setKind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetKind { get; set; }

        [Newtonsoft.Json.JsonProperty("isSeen", Required = Newtonsoft.Json.Required.Always)]
        public bool IsSeen { get; set; }

        [Newtonsoft.Json.JsonProperty("failedUpgrades", Required = Newtonsoft.Json.Required.Always)]
        public int FailedUpgrades { get; set; }

        [Newtonsoft.Json.JsonProperty("primaryBonus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ArtifactBonus PrimaryBonus { get; set; }

        [Newtonsoft.Json.JsonProperty("secondaryBonuses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ArtifactBonus> SecondaryBonuses { get; set; }

        [Newtonsoft.Json.JsonProperty("requiredFraction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequiredFraction { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ArtifactBonus
    {
        [Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kind { get; set; }

        [Newtonsoft.Json.JsonProperty("isAbsolute", Required = Newtonsoft.Json.Required.Always)]
        public bool IsAbsolute { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public float Value { get; set; }

        [Newtonsoft.Json.JsonProperty("enhancement", Required = Newtonsoft.Json.Required.Always)]
        public float Enhancement { get; set; }

        [Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.Always)]
        public int Level { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Hero
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("typeId", Required = Newtonsoft.Json.Required.Always)]
        public int TypeId { get; set; }

        [Newtonsoft.Json.JsonProperty("grade", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Grade { get; set; }

        [Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.Always)]
        public int Level { get; set; }

        [Newtonsoft.Json.JsonProperty("empowerLevel", Required = Newtonsoft.Json.Required.Always)]
        public int EmpowerLevel { get; set; }

        [Newtonsoft.Json.JsonProperty("experience", Required = Newtonsoft.Json.Required.Always)]
        public int Experience { get; set; }

        [Newtonsoft.Json.JsonProperty("fullExperience", Required = Newtonsoft.Json.Required.Always)]
        public int FullExperience { get; set; }

        [Newtonsoft.Json.JsonProperty("locked", Required = Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; }

        [Newtonsoft.Json.JsonProperty("inStorage", Required = Newtonsoft.Json.Required.Always)]
        public bool InStorage { get; set; }

        [Newtonsoft.Json.JsonProperty("marker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Marker { get; set; }

        [Newtonsoft.Json.JsonProperty("artifacts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> Artifacts { get; set; }

        [Newtonsoft.Json.JsonProperty("fraction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fraction { get; set; }

        [Newtonsoft.Json.JsonProperty("rarity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Rarity { get; set; }

        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Role { get; set; }

        [Newtonsoft.Json.JsonProperty("element", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Element { get; set; }

        [Newtonsoft.Json.JsonProperty("awakenLevel", Required = Newtonsoft.Json.Required.Always)]
        public int AwakenLevel { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("health", Required = Newtonsoft.Json.Required.Always)]
        public float Health { get; set; }

        [Newtonsoft.Json.JsonProperty("accuracy", Required = Newtonsoft.Json.Required.Always)]
        public float Accuracy { get; set; }

        [Newtonsoft.Json.JsonProperty("attack", Required = Newtonsoft.Json.Required.Always)]
        public float Attack { get; set; }

        [Newtonsoft.Json.JsonProperty("defense", Required = Newtonsoft.Json.Required.Always)]
        public float Defense { get; set; }

        [Newtonsoft.Json.JsonProperty("criticalChance", Required = Newtonsoft.Json.Required.Always)]
        public float CriticalChance { get; set; }

        [Newtonsoft.Json.JsonProperty("criticalDamage", Required = Newtonsoft.Json.Required.Always)]
        public float CriticalDamage { get; set; }

        [Newtonsoft.Json.JsonProperty("criticalHeal", Required = Newtonsoft.Json.Required.Always)]
        public float CriticalHeal { get; set; }

        [Newtonsoft.Json.JsonProperty("resistance", Required = Newtonsoft.Json.Required.Always)]
        public float Resistance { get; set; }

        [Newtonsoft.Json.JsonProperty("speed", Required = Newtonsoft.Json.Required.Always)]
        public float Speed { get; set; }

        [Newtonsoft.Json.JsonProperty("masteries", Required = Newtonsoft.Json.Required.Always)]
        public List<int> Masteries { get; set; }

        [Newtonsoft.Json.JsonProperty("assignedMasteryScrolls", Required = Newtonsoft.Json.Required.AllowNull)]
        public IReadOnlyDictionary<string, int> AssignedMasteryScrolls { get; set; }

        [Newtonsoft.Json.JsonProperty("unassignedMasteryScrolls", Required = Newtonsoft.Json.Required.AllowNull)]
        public IReadOnlyDictionary<string, int> UnassignedMasteryScrolls { get; set; }

        [Newtonsoft.Json.JsonProperty("totalMasteryScrolls", Required = Newtonsoft.Json.Required.AllowNull)]
        public IReadOnlyDictionary<string, int> TotalMasteryScrolls { get; set; }

        [Newtonsoft.Json.JsonProperty("skills", Required = Newtonsoft.Json.Required.Always)]
        public List<Skill> Skills { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Skill
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("typeId", Required = Newtonsoft.Json.Required.Always)]
        public int TypeId { get; set; }

        [Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.Always)]
        public int Level { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ShardSummonInfo
    {
        [Newtonsoft.Json.JsonProperty("rarity", Required = Newtonsoft.Json.Required.Always)]
        public string Rarity { get; set; }

        [Newtonsoft.Json.JsonProperty("pullCount", Required = Newtonsoft.Json.Required.Always)]
        public int PullCount { get; set; }

        [Newtonsoft.Json.JsonProperty("lastHeroId", Required = Newtonsoft.Json.Required.Always)]
        public int LastHeroId { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ShardInfo
    {
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Always)]
        public int Count { get; set; }

        [Newtonsoft.Json.JsonProperty("summonData", Required = Newtonsoft.Json.Required.Always)]
        public List<ShardSummonInfo> SummonData { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.7.0.0 (NJsonSchema v10.1.24.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.7.0.0 (NJsonSchema v10.1.24.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException<TResult> : ApiException
    {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
