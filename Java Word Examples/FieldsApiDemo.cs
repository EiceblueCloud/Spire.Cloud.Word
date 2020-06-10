using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;


namespace CloudWord
{
    class FieldsApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
        public static void AddField()
        {
            string name = "addField.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            string fieldCode = "DATE  \\@ \"h时m分s秒\"";
            string folder = "input";
            string storage = null;
            string password = null;
            int? indexInParagraph = 0;
            string destFilePath = "output/addField_output.docx";
            fieldsApi.AddField(name, paragraphPath, fieldCode, destFilePath, folder, storage, password, indexInParagraph);
        }

        public static void AddMergeField()
        {
            string name = "addMergeField.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            string fieldName = "FiledTest";
            string folder = "input";
            string storage = null;
            string password = null;
            int? indexInParagraph = 0;
            string fieldCode = null;
            string destFilePath = "output/addMergeField_output.docx";
            fieldsApi.AddMergeField(name, paragraphPath, fieldName, destFilePath, folder, storage, password, indexInParagraph, fieldCode);
        }
        public static void DeleteField()
        {
            string name = "deleteField.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/deleteField_output.docx";
            fieldsApi.DeleteField(name, paragraphPath, index, destFilePath, folder, storage, password);
        }
        public static void GetFields()
        {
            string name = "getFields.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            string paragraphPath = null;
            var response = fieldsApi.GetFields(name, folder, storage, password, paragraphPath);
        }
        public static void UpdateField()
        {
            string name = "updateField.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/updateField_output.docx";
            fieldsApi.UpdateField(name, folder, storage, password, destFilePath);
        }
    }
}
