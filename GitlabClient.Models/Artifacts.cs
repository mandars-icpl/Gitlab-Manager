using Newtonsoft.Json;

namespace GitlabClient.Models
{
    public class Artifacts
    {
        [JsonProperty("file_type")]
        public string FileType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("file_format")]
        public string FileFormat { get; set; }
    }
}