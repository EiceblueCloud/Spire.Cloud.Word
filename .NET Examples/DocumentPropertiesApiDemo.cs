using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.Collections.Generic;

namespace SpireDocCloudDemo
{
    class DocumentPropertiesApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void AddCustomDocumentProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
            string name = "addCustomDocumentProperties.docx";
            List<CustomDocumentProperty> properties = new List<CustomDocumentProperty>();
            properties.Add(new CustomDocumentProperty("propertiesName1", "propertiesValue1"));
            properties.Add(new CustomDocumentProperty("propertiesName2", "propertiesValue2"));
            string password = null;
            string folder = "input";
            string destFilePath = "output/addCustomDocumentProperties_out.docx";
            string storage = null;
            documentPropertiesApi.AddCustomDocumentProperties(name, properties, password, folder, storage, destFilePath);
        }

        public static void DeleteCustomDocumentProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
            string name = "deleteCustomDocumentProperties.docx";
            string propertieName = "E-iceblue";
            string password = null;
            string folder = "input";
            string storage = null;
            string destFilePath = "output/deleteCustomDocumentProperties_output.docx";
            documentPropertiesApi.DeleteCustomDocumentProperties(name, propertieName, password, folder, storage, destFilePath);
        }

        public static void GetBuiltinDocumentProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
            string name = "getBuiltinDocumentProperties.docx";
            string password = null;
            string folder = "input";
            string storage = null;
            var response = documentPropertiesApi.GetBuiltinDocumentProperties(name, password, folder, storage);
        }

        public static void GetCustomDocumentProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
            string name = "getCustomDocumentProperties.docx";
            string password = null;
            string folder = "input";
            string storage = null;
            var response = documentPropertiesApi.GetCustomDocumentProperties(name, password, folder, storage);
        }
    }
}
