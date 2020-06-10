using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudWord
{
    class EncryptApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static EncryptApi encryptApi = new EncryptApi(wordConfiguration);
        public static void EncryptDocument()
        {
            string name = "encryptDocument.docx";
            string folder = "input";
            string oldPassword = null;
            string newPassword = "123456";
            string destFilePath = "output/encryptDocument_output.docx";
            string storage = null;
            encryptApi.EncryptDocument(name, destFilePath, folder, storage, oldPassword, newPassword);
        }
        public static void EncryptDocumentInRequest()
        {
            Stream inputFile = new FileStream("D:/inputFile/encryptDocument.docx", FileMode.Open);
            string oldPassword = null;
            string newPassword = "123456";
            encryptApi.EncryptDocumentInRequest(inputFile, oldPassword, newPassword);
        }
    }
}
