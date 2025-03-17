using System.Text.Json.Serialization;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(Dictionary<string, string>))]
[JsonSerializable(typeof(string))]
internal partial class HybridSampleJSContext : JsonSerializerContext {
    // This type's attributes specify JSON serialization info to preserve type structure
    // for trimmed builds.  
}