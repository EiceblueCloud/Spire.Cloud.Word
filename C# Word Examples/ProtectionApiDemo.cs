using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Api;
using System;
using System.IO;

namespace CloudWord
{
    class ProtectionApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string basePath = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, basePath);
        static ProtectionApi protectionApi = new ProtectionApi(wordConfiguration);
        public static void ProtectDocument()
        {
            var fileName = "Template.docx";
            string name = fileName;
            string protectionType = "AllowOnlyReading"; //AllowOnlyComments,AllowOnlyFormFields,AllowOnlyRevisions,NoProtection
            string folder = "input";
            string storage = null;
            string docPassword = null;
            string protectiongPwd = "123456";
            string destFilePath = "output/Template_output.docx" ;
            protectionApi.ProtectDocument(name, protectionType, destFilePath, folder, storage, docPassword, protectiongPwd);
        }
        public static void ProtectDocumentWithFile()
        {
            string inputFilePath = "D:/inputFile/Template.docx";
            System.IO.Stream inputFile = new FileStream(inputFilePath, FileMode.Open);
            string protectionType = "AllowOnlyReading"; //AllowOnlyComments,AllowOnlyFormFields,AllowOnlyRevisions,NoProtection
            string docPassword = null;
            string protectiongPwd = "123456";
            var response = protectionApi.ProtectDocumentInRequest(inputFile, protectionType, docPassword, protectiongPwd);
        }

    }
}