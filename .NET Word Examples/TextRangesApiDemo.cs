using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class TextRangesApiDemo
    {
        static String appId = "your id";
        static String appKey = "your key";
        public static void AddTextRange()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TextRangesApi textRangesApi = new TextRangesApi(wordConfiguration);
            var fileName = "addTextRange.docx";
            string name = fileName;
            string paragraphPath = "sections/0/paragraphs/0";
            int? indexInParagraph = 0;
            TextRangeFormat textRange = new TextRangeFormat
            {
                Text = "E-iceblue",
                Font = new Font(40, "宋体")
                {
                    Color = new Color(0, 255, 255)
                }
            };
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/AddTextRange_output.docx";
            textRangesApi.AddTextRange(name, paragraphPath, textRange, folder, storage, indexInParagraph, password, destFilePath);
        }
        public static void DeleteTextRange()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TextRangesApi textRangesApi = new TextRangesApi(wordConfiguration);
            var fileName = "deleteTextRange.docx";
            string name = fileName;
            string paragraphPath = "sections/0/paragraphs/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTextRange_output.docx";
            textRangesApi.DeleteTextRange(name, paragraphPath, index, folder, storage, password, destFilePath);
        }
        public static void GetTextRangeProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TextRangesApi textRangesApi = new TextRangesApi(wordConfiguration);
            var fileName = "getTextRangeProperties.docx";
            string name = fileName;
            string paragraphPath = "sections/0/paragraphs/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = textRangesApi.GetTextRangeProperties(name, paragraphPath, index, folder, storage, password);
        }
        public static void UpdateTextRange()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TextRangesApi textRangesApi = new TextRangesApi(wordConfiguration);
            var fileName = "updateTextRange.docx";
            string name = fileName;
            string paragraphPath = "sections/0/paragraphs/0";
            int? index = 0;
            TextRangeFormat textRange = new TextRangeFormat
            {
                Text = "E-iceblue",
                Font = new Font(30, "宋体")
                {
                    Color = new Color(0, 255, 255)
                }
            }; ;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/UpdateTextRange_output.docx";
            textRangesApi.UpdateTextRange(name, paragraphPath, index, textRange, folder, storage, password, destFilePath);
        }
    }
}
