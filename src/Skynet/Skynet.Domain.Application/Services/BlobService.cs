using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Skynet.Domain.Application.Abstractions;
using Skynet.Domain.Application.DTO.Blob;

namespace Skynet.Domain.Application.Services
{
    public class BlobService : IBlobService
    {
        private readonly IConfiguration _configuration;

        private CloudStorageAccount _cloudStorageAccount;
        private CloudBlobClient _cloudBlobClient;
        private CloudBlobContainer _cloudBlobContainer;
        private CloudBlockBlob _cloudBlockBlob;

        public BlobService(IConfiguration configuration)
        {
            _configuration = configuration;
            ConfigureStorage();
        }

        private void ConfigureStorage()
        {
            _cloudStorageAccount = CloudStorageAccount.Parse(_configuration["Storage:ConnectionString"]);
            _cloudBlobClient = _cloudStorageAccount.CreateCloudBlobClient();
            _cloudBlobContainer = _cloudBlobClient.GetContainerReference(_configuration["Storage:BlobContainer"]);
        }

        public async Task<CreateBlobResponse> CreateBlobAsync(CreateBlobRequest request)
        {
            var blobId = Guid.NewGuid().ToString();

            var fileBytes = Convert.FromBase64String(request.Base64File);

            _cloudBlockBlob = _cloudBlobContainer.GetBlockBlobReference(BuildReference(blobId, request.Extension));

            await _cloudBlockBlob.UploadFromByteArrayAsync(fileBytes, 0, fileBytes.Length);

            return new CreateBlobResponse()
            {
                Path = _cloudBlockBlob.StorageUri.PrimaryUri.AbsoluteUri,
                BlobId = blobId,
            };
        }

        private string BuildReference(string blobId, string extension) => $"{blobId}.{SanitizeExtension(extension)}";

        private static string SanitizeExtension(string extension) => extension.Replace(".", "");
    }
}
