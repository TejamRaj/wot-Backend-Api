using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WorkPlaceOnTour.BACKEND.Components
{
    public class TourWorkplacePhotographs :ITourWorkplacePhotographs
    {
        public async Task<string> SaveTourWorkplacePhotographas(string fileName, Stream content)
        {
            var baseUri = new Uri("https://redsoilmusic.blob.core.windows.net/");
            var containerName = "publicart";
            var credentials = new StorageCredentials("redsoilmusic", "0Eg772Bh787ElLPEp++LLTsUNOjk2KFUaQR1KLOxXg20Q6wsSYXel7GPkFtuIxBnAHGhn94NsnBJzV4m7jdAow==");
            var client = new CloudBlobClient(baseUri, credentials);

            var container = client.GetContainerReference(containerName);
            var blob = container.GetBlockBlobReference(fileName);
            await blob.UploadFromStreamAsync(content);

            return $"{baseUri}{containerName}/{fileName}";
        }
    }
}
