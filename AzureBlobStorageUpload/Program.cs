namespace AzureBlobStorageUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            AzureUploadBlobLegacy.UploadBlob.UploadFromByteArray(args[0], args[1], args[2]);

            AzureUploadBlobCurrent.UploadBlob.UploadFromByteArray(args[0], args[1], args[2]);

            AzureUploadBlobLegacy.UploadBlob.UploadFromStream(args[0], args[1], args[2]);

            AzureUploadBlobCurrent.UploadBlob.UploadFromStream(args[0], args[1], args[2]);

            AzureUploadBlobLegacy.UploadBlob.UploadFromText(args[0], args[1], args[2]);

            AzureUploadBlobCurrent.UploadBlob.UploadFromText(args[0], args[1], args[2]);

            AzureUploadBlobLegacy.UploadBlob.UploadFromFile(args[0], args[1], args[2]);

            AzureUploadBlobCurrent.UploadBlob.UploadFromFile(args[0], args[1], args[2]);
        }
    }
}
