using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GitlabClient.Models
{
    public class Pipeline
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iid")]
        public int Iid { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
