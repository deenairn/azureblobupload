namespace AzureUploadBlobLegacy
{
    using System;
    using System.IO;
    using Microsoft.WindowsAzure.Storage;

    public class UploadBlob
    {
        public static void UploadFromByteArray(
                string storageAccountName,
                string containerName,
                string filepath
            )
        {
            var storageAccount = CloudStorageAccount.Parse(storageAccountName);
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference(containerName);
            container.CreateIfNotExists();

            var fileName = Path.GetFileNameWithoutExtension(filepath);

            var blockBlob = container.GetBlockBlobReference($"{fileName}-{nameof(UploadFromByteArray)}Legacy-{Guid.NewGuid()}");

            blockBlob.UploadFromFile(filepath);
        }


        public static void UploadFromFile(
            string storageAccountName,
            string containerName,
            string filepath
        )
        {
            var storageAccount = CloudStorageAccount.Parse(storageAccountName);
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference(containerName);
            container.CreateIfNotExists();

            var fileName = Path.GetFileNameWithoutExtension(filepath);

            var blockBlob = container.GetBlockBlobReference($"{fileName}-{nameof(UploadFromFile)}-{Guid.NewGuid()}");

            blockBlob.UploadFromFile(filepath);
        }

        public static void UploadFromStream(
            string storageAccountName,
            string containerName,
            string filepath
        )
        {
            var storageAccount = CloudStorageAccount.Parse(storageAccountName);
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference(containerName);
            container.CreateIfNotExists();

            var fileName = Path.GetFileNameWithoutExtension(filepath);

            var blockBlob = container.GetBlockBlobReference($"{fileName}-{nameof(UploadFromStream)}-{Guid.NewGuid()}");

            var stream = File.OpenRead(filepath);
            blockBlob.UploadFromStream(stream);
        }

        public static void UploadFromText(
            string storageAccountName,
            string containerName,
            string filepath
        )
        {
            var storageAccount = CloudStorageAccount.Parse(storageAccountName);
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference(containerName);
            container.CreateIfNotExists();

            var fileName = Path.GetFileNameWithoutExtension(filepath);

            var blockBlob = container.GetBlockBlobReference($"{fileName}-{nameof(UploadFromText)}-{Guid.NewGuid()}");

            var text = File.ReadAllText(filepath);
            blockBlob.UploadText(text);
        }
    }
}
