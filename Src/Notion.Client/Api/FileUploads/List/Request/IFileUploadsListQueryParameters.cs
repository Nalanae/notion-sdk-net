using Newtonsoft.Json;

namespace Notion.Client
{
    public interface IFileUploadsListQueryParameters : IPaginationParameters
    {
        [JsonProperty("status")]
        public FileUploadStatus Status { get; set; }
    }
}
