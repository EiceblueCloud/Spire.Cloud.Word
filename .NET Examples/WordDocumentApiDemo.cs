using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;

namespace SpireDocCloudDemo
{
    class WordDocumentApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void CreateDocument()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            WordDocumentApi wordDocumentApi = new WordDocumentApi(wordConfiguration);
            string fileFormat = "docx";
            string name = "createDocument_output";
            string destFolder = "output";
            string storage = null;
            wordDocumentApi.CreateDocument(fileFormat, name, destFolder, storage);
        }
    }
}
