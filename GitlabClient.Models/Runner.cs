using Newtonsoft.Json;

namespace GitlabClient.Models
{
    public class Runner
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ip_address")]
        public object IpAddress { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("paused")]
        public string Paused { get; set; }

        [JsonProperty("is_shared")]
        public bool IsShared { get; set; }

        [JsonProperty("runner_type")]
        public string RunnerType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}