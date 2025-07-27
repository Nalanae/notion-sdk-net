using System.Threading;
using System.Threading.Tasks;

namespace Notion.Client
{
    public interface IFileUploadsClient
    {
        /// <summary>
        ///     Returns a paginated list of file uploads for the current bot integration.
        ///     The response may contain fewer than page_size of results.
        /// </summary>
        /// <param name="listFileUploadsParameters"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        ///     <see cref="ListFileUploadsResponse" />
        /// </returns>
        Task<ListFileUploadsResponse> ListAsync(FileUploadsListParameters listFileUploadsParameters, CancellationToken cancellationToken = default);
        Task<FileUpload> RetrieveAsync(string fileUploadId, CancellationToken cancellationToken = default);
        Task<FileUpload> CreateAsync(FileUploadsCreateParameters fileUploadsCreateParameters, CancellationToken cancellationToken = default);
        Task<FileUpload> CompleteAsync(string fileUploadId, CancellationToken cancellationToken = default);
        Task<FileUpload> SendAsync(string fileUploadId, string fileName, byte[] data, int? partNumber = null, CancellationToken cancellationToken = default);
    }
}
