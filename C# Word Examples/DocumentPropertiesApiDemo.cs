using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.Collections.Generic;

namespace CloudWord
{
    class DocumentPropertiesApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
        public static void AddCustomDocumentProperties()
        {
            string name = "addCustomDocumentProperties.docx";
            List<CustomDocumentProperty> properties = new List<CustomDocumentProperty>();
            properties.Add(new CustomDocumentProperty("propertiesName1", "propertiesValue1"));
            properties.Add(new CustomDocumentProperty("propertiesName2", "propertiesValue2"));
            string password = null;
            string folder = "input";
            string destFilePath = "output/addCustomDocumentProperties_out.docx";
            string storage = null;
            documentPropertiesApi.AddCustomDocumentProperties(name, properties, destFilePath, password, folder, storage);
        }

        public static void DeleteCustomDocumentProperty()
        {
            string name = "deleteCustomDocumentPropertie.docx";
            string propertieName = "E-iceblue";
            string password = null;
            string folder = "input";
            string storage = null;
            string destFilePath = "output/deleteCustomDocumentProperties_output.docx";
            documentPropertiesApi.DeleteCustomDocumentProperty(name, propertieName, destFilePath, password, folder, storage);
        }

        public static void GetBuiltinDocumentProperties()
        {
            string name = "getBuiltinDocumentProperties.docx";
            string password = null;
            string folder = "input";
            string storage = null;
            var response = documentPropertiesApi.GetBuiltinDocumentProperties(name, password, folder, storage);
        }

        public static void GetCustomDocumentProperties()
        {
            string name = "getCustomDocumentProperties.docx";
            string password = null;
            string folder = "input";
            string storage = null;
            var response = documentPropertiesApi.GetCustomDocumentProperties(name, password, folder, storage);
        }
    }
}
