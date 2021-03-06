// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var plantsJson = PlantsJson.FromJson(jsonString);

namespace PlantJson_QuickType
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PlantsJson
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("plant_name")]
        public string PlantName { get; set; }

        [JsonProperty("use_of_water")]
        public long UseOfWater { get; set; }

        [JsonProperty("time_delay")]
        public long TimeDelay { get; set; }

        [JsonProperty("plant_description")]
        public string PlantDescription { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("hydration_needed")]
        public long HydrationNeeded { get; set; }
    }

    public partial class PlantsJson
    {
        public static PlantsJson[] FromJson(string json) => JsonConvert.DeserializeObject<PlantsJson[]>(json, PlantJson_QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PlantsJson[] self) => JsonConvert.SerializeObject(self, PlantJson_QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
