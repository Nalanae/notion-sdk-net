using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ListFileUploadsResponse : PaginatedList<FileUpload>
    {
        [JsonProperty("file_upload")]
        public Dictionary<string, object> FileUpload { get; set; }
    }
}
