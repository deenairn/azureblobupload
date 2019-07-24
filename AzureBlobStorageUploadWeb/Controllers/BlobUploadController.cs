using System.Web.Http;

namespace AzureBlobStorageUploadWeb.Controllers
{
    using System.Threading.Tasks;
    using Models;

    public class BlobUploadController : ApiController
    {
        [Route("api/blobupload/bytearray"), HttpPost]
        public void ByteArray([FromBody]BlobConfigModel blobConfigModel)
        {
            AzureUploadBlobLegacy.UploadBlob.UploadFromByteArray(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath);

            // TODO: Uncomment these lines to fix
            //Task.Run(() => 
            AzureUploadBlobCurrent.UploadBlob.UploadFromByteArray(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath)
            //).Wait()
            ;
        }

        [Route("api/blobupload/stream"), HttpPost]
        public void Stream([FromBody]BlobConfigModel blobConfigModel)
        {
            AzureUploadBlobLegacy.UploadBlob.UploadFromStream(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath);

            // TODO: Uncomment these lines to fix
            //Task.Run(() => 
            AzureUploadBlobCurrent.UploadBlob.UploadFromStream(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath);
                //).Wait()
                ;
        }

        [Route("api/blobupload/text"), HttpPost]
        public void Text([FromBody]BlobConfigModel blobConfigModel)
        {
            AzureUploadBlobLegacy.UploadBlob.UploadFromText(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath);

            // TODO: Uncomment these lines to fix
            //Task.Run(() => 
            AzureUploadBlobCurrent.UploadBlob.UploadFromText(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath);
            //).Wait()
            ;
        }

        [Route("api/blobupload/file"), HttpPost]
        public void File([FromBody]BlobConfigModel blobConfigModel)
        {
            AzureUploadBlobLegacy.UploadBlob.UploadFromFile(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath);

            // TODO: Uncomment these lines to fix
            //Task.Run(() => 
            AzureUploadBlobCurrent.UploadBlob.UploadFromFile(blobConfigModel.storageAccount, blobConfigModel.container, blobConfigModel.filePath);
            //).Wait()
            ;
        }
    }
}
