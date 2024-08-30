using Newtonsoft.Json;

namespace GitlabClient.Models
{
    public class Commit
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("parent_ids")]
        public string[] ParentIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_email")]
        public string AuthorEmail { get; set; }

        [JsonProperty("authored_date")]
        public string AuthoredDate { get; set; }

        [JsonProperty("committer_name")]
        public string CommiterName { get; set; }

        [JsonProperty("committer_email")]
        public string CommiterEmail { get; set; }

        [JsonProperty("committed_date")]
        public string CommittedDate { get; set; }

        [JsonProperty("trailers")]
        public object Trailers { get; set; }

        [JsonProperty("extended_trailers")]
        public string ExtendedTrailers { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

    }
}