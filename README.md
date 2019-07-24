# Test App for Azure Blob "Defect"

Simple test app for defect introduced into blob storage "UploadFromByteArray" from version 9.3.3 to 9.4.0. This coincided with the library being packaged as a single DLL, "Microsoft.WindowsAzure.Storage" to separate assemblies "Microsoft.Azure.Storage.Blob".

## Description

The test app runs code that 

1. Calls method UploadFrom(ByteArray|Stream|Text|File) via 9.3.3, and then 
2. Calls method UploadFrom(ByteArray|Stream|Text|File) via 9.4.0. 

Via the console application, it can be confirmed that even for files up to 256MB the method works successfully.

There is then a test Web API. This is accessed using the following endpoints:

* (hostname)/api/blobupload/bytearray
* (hostname)/api/blobupload/stream
* (hostname)/api/blobupload/text
* (hostname)/api/blobupload/files

These are accessed via a POST request using a JSON of the form below. The values are the test values for myself locally, but change the storage account, container and file path as appropriate. I used Postman to do the requests.

```
{
	"storageAccount": "UseDevelopmentStorage=true",
	"container": "upload",
	"filePAth": "C:\\Temp\\256MB"
}
```

It can be seen for files >= 256MB that this works for the previous implementation (9.3.3), but after 9.4.0 it now fails. It can be fixed if it is wrapped in a:

```
Task.Run(() => x.UploadFrom...).Wait()
```
