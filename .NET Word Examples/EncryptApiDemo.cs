using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpireDocCloudDemo
{
    class EncryptApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void EncryptDocument()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            EncryptApi encryptApi = new EncryptApi(wordConfiguration);
            string name = "encryptDocument.docx";
            string folder = "input";
            string oldPassword = null;
            string newPassword = "123456";
            string destFilePath = "output/encryptDocument_output.docx";
            string storage = null;
            encryptApi.EncryptDocument(name, folder, storage, oldPassword, newPassword, destFilePath);
        }
    }
}
