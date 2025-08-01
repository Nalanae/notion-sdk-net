﻿namespace Notion.Client
{
    public class FileUploadsCreateParameters : IFileUploadsCreateBodyParameters
    {
        public FileUploadMode Mode { get; set; }
        public string Filename { get; set; }
        public string ContentType { get; set; }
        public int NumberOfParts { get; set; }
        public string ExternalUrl { get; set; }
    }
}
