using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class TextRangesApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static TextRangesApi textRangesApi = new TextRangesApi(wordConfiguration);
        public static void AddTextRange()
        {
            string name = "Template.docx"; 
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? indexInParagraph = 0;
            string text = "E-iceblue";
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/AddTextRange_output.docx";
            textRangesApi.AddTextRange(name, paragraphPath, text, destFilePath, folder, storage, indexInParagraph, password);
        }
        public static void DeleteTextRange()
        {
            string name = "deleteTextRange.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTextRange_output.docx";
            textRangesApi.DeleteTextRange(name, paragraphPath, index, destFilePath,folder, storage, password);
        }
        public static void GetTextRangeFormat()
        {
            string name = "getTextRangeFormat.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = textRangesApi.GetTextRangeFormat(name, paragraphPath, index, folder, storage, password);
        }
        public static void GetTextRangeText()
        {
            string name = "Template.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = textRangesApi.GetTextRangeText(name, paragraphPath, index, folder, storage, password);
        }
        public static void GetTextRanges()
        {
            string name = "Template.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            string folder = "input";
            string storage = null;
            string password = null;
            var response = textRangesApi.GetTextRanges(name, paragraphPath, folder, storage, password);
        }
        public static void UpdateTextRangeFormat()
        {
            string name = "Template.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? index = 0;
            TextRangeFormat textRange = new TextRangeFormat
            {
                Font = new Font(30, "Arial")
                {
                    Color = new Color(0, 255, 255)
                }
            }; 
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/UpdateTextRangeFormat_output.docx";
            textRangesApi.UpdateTextRangeFormat(name, paragraphPath, index, textRange, destFilePath, folder, storage, password);

        }
        public static void UpdateTextRangeText()
        {
            string name = "Template.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0"; ;
            int? index = 0;
            string text = "E-iceblue test textRange";
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/UpdateTextRangeText_output.docx";
            var response = textRangesApi.UpdateTextRangeText(name, paragraphPath, index, text, destFilePath, folder, storage, password);
        }
    }
}
