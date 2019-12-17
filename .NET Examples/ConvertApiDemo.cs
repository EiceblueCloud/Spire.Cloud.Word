using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;
using System.IO;

namespace SpireDocCloudDemo
{
    class ConvertApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void ConvertDocumentWithFile()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ConvertApi convertApi = new ConvertApi(wordConfiguration);
            Stream inputfile = new FileStream("../../inputFile/convertDocumentWithFile.docx", FileMode.Open);
            string format = "pdf";
            string password = null;
            var response = convertApi.ConvertDocumentWithFile(inputfile, format, password);
        }

        public static void ConvertDocument()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ConvertApi convertApi = new ConvertApi(wordConfiguration);
            string name = "convertDocument.docx";
            string format = "xps";
            string password = null;
            string folder = "input";
            string storage = null;
            string destFilePath = "output/convertDocument_output.xps";
            convertApi.ConvertDocument(name, format, password, folder, storage, destFilePath);
        }
    }
}
