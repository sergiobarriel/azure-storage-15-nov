using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace SkynetPI.Target.Services
{
    public class QueueService
    {
        private readonly CloudStorageAccount _cloudStorageAccount;
        private readonly CloudQueueClient _cloudQueueClient;
        private readonly CloudQueue _cloudQueue;

        public QueueService(IConfiguration configuration)
        {
            _cloudStorageAccount = CloudStorageAccount.Parse(configuration["Storage:ConnectionString"]);
            _cloudQueueClient = _cloudStorageAccount.CreateCloudQueueClient();
            _cloudQueue = _cloudQueueClient.GetQueueReference(configuration["Storage:QueueContainer"]);
        }

        public string GetMessage()
        {
            var message = _cloudQueue.GetMessageAsync().Result;

            if (message == null) return null;

            var text = message.AsString;

            _cloudQueue.DeleteMessageAsync(message).Wait();

            return text;
        }
    }
}
