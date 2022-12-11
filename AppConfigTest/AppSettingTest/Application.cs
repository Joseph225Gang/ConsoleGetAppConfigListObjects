using Newtonsoft.Json;

namespace AppSettingTest
{
    [Newtonsoft.Json.JsonObject("application")]
    public class Application
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
