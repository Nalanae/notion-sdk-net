using Newtonsoft.Json;

namespace Notion.Client
{
    public class FileUploadsListParameters : IFileUploadsListQueryParameters
    {
        public FileUploadStatus Status { get; set; }

        public string StartCursor { get; set; }

        public int? PageSize { get; set; }
    }
}
