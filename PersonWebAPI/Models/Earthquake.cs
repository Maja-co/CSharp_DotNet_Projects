using System.Text.Json.Serialization;

namespace PersonWebAPI.Models;

public class Earthquake {
}

public class EarthquakeResponse {
    [JsonPropertyName("features")] public List<Feature> Features { get; set; } = new();
}

public class Feature {
    [JsonPropertyName("properties")] public QuakeProperties Properties { get; set; } = new();
}

public class QuakeProperties {
    [JsonPropertyName("mag")] public double Magnitude { get; set; }

    [JsonPropertyName("place")] public string Place { get; set; } = string.Empty;

    [JsonPropertyName("time")] public long Time { get; set; }
}