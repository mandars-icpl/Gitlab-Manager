using Newtonsoft.Json;

namespace GitlabClient.Models
{
    public class Project
    {
        [JsonProperty("ci_job_token_scope_enabled")]
        public bool CiJobTokenScopeEnabled { get; set; }
    }
}