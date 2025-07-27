using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Notion.Client.Extensions;

namespace Notion.Client
{
    public class FileUploadsClient : IFileUploadsClient
    {
        private readonly IRestClient _client;

        public FileUploadsClient(IRestClient client)
        {
            _client = client;
        }

        public async Task<ListFileUploadsResponse> ListAsync(
            FileUploadsListParameters fileUploadsListParameters, CancellationToken cancellationToken = default)
        {
            var url = ApiEndpoints.FileUploadsApiUrls.List();

            var queryParameters = (IFileUploadsListQueryParameters)fileUploadsListParameters;

            var queryParams = new Dictionary<string, string>
            {
                { "status", queryParameters?.Status.GetEnumMemberValue() },
                { "start_cursor", queryParameters?.StartCursor },
                { "page_size", queryParameters?.PageSize?.ToString() }
            };

            return await _client.GetAsync<ListFileUploadsResponse>(url, queryParams, cancellationToken: cancellationToken);
        }

        public async Task<FileUpload> RetrieveAsync(string fileUploadId, CancellationToken cancellationToken = default)
        {
            var url = ApiEndpoints.FileUploadsApiUrls.Retrieve(fileUploadId);

            return await _client.GetAsync<FileUpload>(url, cancellationToken: cancellationToken);
        }

        public async Task<FileUpload> CreateAsync(
            FileUploadsCreateParameters fileUploadsCreateParameters, CancellationToken cancellationToken = default)
        {
            var url = ApiEndpoints.FileUploadsApiUrls.Create();

            var body = (IFileUploadsCreateBodyParameters)fileUploadsCreateParameters;

            return await _client.PostAsync<FileUpload>(url, body, cancellationToken: cancellationToken);
        }

        public async Task<FileUpload> CompleteAsync(string fileUploadId, CancellationToken cancellationToken = default)
        {
            var url = ApiEndpoints.FileUploadsApiUrls.Complete(fileUploadId);

            return await _client.PostAsync<FileUpload>(url, new object(), cancellationToken: cancellationToken);
        }

        public async Task<FileUpload> SendAsync(string fileUploadId, string fileName, byte[] data, int? partNumber = null, CancellationToken cancellationToken = default)
        {
            var url = ApiEndpoints.FileUploadsApiUrls.Send(fileUploadId);

            var content = new MultipartFormDataContent

            {
                { new ByteArrayContent(data), "file", fileName }
            };

            if (partNumber != null)
            {
                content.Add(new StringContent(partNumber.ToString()), "part_number");
            }

            return await _client.PostMultipartFormDataAsync<FileUpload>(url, content, cancellationToken: cancellationToken);
        }
    }
}
