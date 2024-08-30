using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitlabClient.Models
{
    internal class Job
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("tag")]
        public bool Tag { get; set; }

        [JsonProperty("coverage")]
        public string Coverage { get; set; }

        [JsonProperty("allow_failure")]
        public bool AllowFailure { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("started_at")]
        public DateTime StartedAt { get; set; }

        [JsonProperty("finished_at")]
        public DateTime FinishedAt { get; set; }

        [JsonProperty("erased_at")]
        public DateTime ErasedAt { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("queued_duration")]
        public double QueuedDuration { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("commit")]
        public Commit Commit { get; set; }

        [JsonProperty("pipeline")]
        public Pipeline Pipeline { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("runner")]
        public Runner Runner { get; set; }

        [JsonProperty("artifacts")]
        public Artifacts Artifacts { get; set; }

        [JsonProperty("runner_manager")]
        public string RunnerManager { get; set; }

        [JsonProperty("artifacts_expires_at")]
        public DateTime ArtifactsExpiresAt { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("tag_list")]
        public List<string> TagList { get; set; }


    }
}
