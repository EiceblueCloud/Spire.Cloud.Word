using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;

namespace CloudWord
{
    class WordDocumentApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static WordDocumentApi wordDocumentApi = new WordDocumentApi(wordConfiguration);
        public static void CreateDocument()
        {         
            string fileFormat = "docx";//doc, rtf, wordml, docm, dotx, dot, dotm
            string name = "createDocument_output";
            string destFolder = "output";
            string storage = null;
            wordDocumentApi.CreateDocument(fileFormat, name, destFolder, storage);
        }
        public static void GetDocumentChildObjects()
        {
            var name = "template.docx"; 
            string folder = "input";
            string storage = null;
            string password = null;
            var response = wordDocumentApi.GetDocumentChildObjects(name, folder, storage, password);
        }
    }
}
