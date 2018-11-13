package main.java.services;

import java.util.Properties;
import com.microsoft.azure.storage.CloudStorageAccount;
import com.microsoft.azure.storage.queue.CloudQueue;
import com.microsoft.azure.storage.queue.CloudQueueClient;
import com.microsoft.azure.storage.queue.CloudQueueMessage;

public class StorageService {

    private CloudQueue _queueReference;
    private CloudQueueClient _queueClient;
    private CloudStorageAccount _storageAccount;

    public StorageService(Properties properties) throws Exception {

        _storageAccount = CloudStorageAccount.parse(properties.getProperty("connectionString"));
        _queueClient = _storageAccount.createCloudQueueClient();
        _queueReference = _queueClient.getQueueReference(properties.getProperty("queue"));

    }

    public void SendMessage(String target) throws Exception {

        ConsoleService.PrintMessage("Sending '" + target + "' to target queue...");

        CloudQueueMessage message = new CloudQueueMessage(target);
        _queueReference.addMessage(message);

        ConsoleService.PrintMessage("Target added.\r\n");
    }

}

