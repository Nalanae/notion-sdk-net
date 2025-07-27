using System;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ApiUploadedFileWithName : FileObjectWithName
    {
        public override string Type => "file_upload";

        [JsonProperty("file_upload")]
        public Info FileUpload { get; set; }

        public class Info
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }
    }
}
