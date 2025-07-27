using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    public interface IFileUploadsCreateBodyParameters
    {
        [JsonProperty("mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FileUploadMode Mode { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("number_of_parts")]
        public int NumberOfParts { get; set; }

        [JsonProperty("external_url")]
        public string ExternalUrl { get; set; }
    }
}
