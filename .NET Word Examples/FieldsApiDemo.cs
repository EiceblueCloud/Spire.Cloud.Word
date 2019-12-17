using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;


namespace SpireDocCloudDemo
{
    class FieldsApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void AddField()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
            string name = "addField.docx";
            string paragraphPath = "sections/0/paragraphs/0";
            string fieldCode = "DATE  \\@ \"h时m分s秒\"";
            string folder = "input";
            string storage = null;
            string password = null;
            int? indexInParagraph = 0;
            string destFilePath = "output/addField_output.docx";
            fieldsApi.AddField(name, paragraphPath, fieldCode, folder, storage, password, indexInParagraph, destFilePath);
        }

        public static void AddMergeField()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
            string name = "addMergeField.docx";
            string paragraphPath = "sections/0/paragraphs/0";
            string fieldName = "FiledTest";
            string folder = "input";
            string storage = null;
            string password = null;
            int? indexInParagraph = 0;
            string fieldCode = null;
            string destFilePath = "output/addMergeField_output.docx";
            fieldsApi.AddMergeField(name, paragraphPath, fieldName, folder, storage, password, indexInParagraph, fieldCode, destFilePath);
        }

        public static void DeleteField()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
            string name = "deleteField.docx";
            string paragraphPath = "sections/0/paragraphs/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/deleteField_output.docx";
            fieldsApi.DeleteField(name, paragraphPath, index, folder, storage, password, destFilePath);
        }

        public static void UpdateField()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
            string name = "updateField.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/updateField_output.docx";
            fieldsApi.UpdateField(name, folder, storage, password, destFilePath);
        }
    }
}
