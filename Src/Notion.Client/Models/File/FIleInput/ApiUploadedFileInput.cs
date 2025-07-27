using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ApiUploadedFileInput : IFileObjectInput
    {
        [JsonProperty("file_upload")]
        public Data File { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public IEnumerable<RichTextBaseInput> Caption { get; set; }

        public class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }
    }
}
