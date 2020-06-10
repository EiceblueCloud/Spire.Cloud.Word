using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class ParagraphsApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);
        public static void AddParagraph()
        {         
            var fileName = "addParagraph.docx";
            string name = fileName;
            string nodePath = "Section/0/Body/0";
            int indexOfParagraph = 1;
            string folder = "input";
            string password = null;
            string text = "E-iceblue";
            string destFilePath = "output/AddParagraph_output.docx";
            string storage = null;
            paragraphsApi.AddParagraph(name, nodePath, destFilePath, folder, storage, indexOfParagraph, password, text);
        }
        public static void DeleteParagraph()
        {
            var fileName = "deleteParagraph.docx";
            string name = fileName;
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string password = null;
            string storage = null;
            string destFilePath = "output/DeleteParagraph_output.docx";
            paragraphsApi.DeleteParagraph(name, nodePath, index, destFilePath, folder, storage, password);
        }
        public static void GetParagraphChildObjects()
        {
            var fileName = "getParaChildObjects.docx";
            string name = fileName;
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;   
            var response = paragraphsApi.GetParagraphChildObjects(name, nodePath, index, folder, storage,password);
        }
        public static void GetParagraphformat()
        {
            var fileName = "getParagraphformat.docx";
            string name = fileName;
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null; 
            var response = paragraphsApi.GetParagraphFormat(name, nodePath, index, folder, storage,password);
        }
        public static void GetParagraphs()
        {
            string fileName = "getParagraphs.docx";
            string name = fileName;
            string folder = "input";
            string storage = null;
            string password = null;
            string nodePath = null;
            var response = paragraphsApi.GetParagraphs(name, folder, storage, password, nodePath);
        }
        public static void UpdateParagraphFormat()
        {
            var fileName = "updateParagraphFormat.docx";
            string name = fileName;
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            ParagraphFormat format = new ParagraphFormat
            {
                HorizontalAlignment = ParagraphFormat.HorizontalAlignmentEnum.Distribute,
                LeftOrInnerIndent = 20,
                RightOrOutsideIndent = 10,
                MirrorIndents = false,
                FirstLineIndent = 30,
                BackgroundColor = new Color(0, 200, 200),
                BeforeSpacing = 40,
                AfterSpacing = 40,
                BeforeAutoSpacing = false,
                AfterAutoSpacing = false,
                LineSpace = 50,
                LineSpacingRule = ParagraphFormat.LineSpacingRuleEnum.Exactly,
                WordWrap = true,
                Borders = new Borders(
                    new Border(
                        Border.BorderTypeEnum.Double,
                        new Color(255, 10, 10),
                        true,
                        2))
            };
            string destFilePath = "output/UpdateParagraphFormat_output.docx";
            paragraphsApi.UpdateParagraphFormat(name, nodePath, index, format, destFilePath,folder, storage, password );
        }
        public static void UpdateParagraphText()
        {
            var fileName = "updateParagraphText.docx";
            string name = fileName;
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string text = "E-iceblue";
            string folder = "input";
            string password = null;
            string storage = null;
            string destFilePath = "output/UpdateParagraphText_output.docx";
            paragraphsApi.UpdateParagraphText(name, nodePath, index, text, destFilePath,folder, storage, password);
        }
    }
}
