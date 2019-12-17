using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class ParagraphsApiDemo
    {
        static String appId = "your id";
        static String appKey = "your key";
        public static void AddParagraph()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);
            var fileName = "addParagraph.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int indexOfParagraph = 1;
            string folder = "input";
            string password = null;
            string text = "E-iceblue";
            string destFilePath = "output/AddParagraph_output.docx";
            string storage = null;
            paragraphsApi.AddParagraph(name, nodePath, folder, storage, indexOfParagraph, password, text, destFilePath);
        }
        public static void DeleteParagraph()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);
            var fileName = "deleteParagraph.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int? index = 0;
            string folder = "input";
            string password = null;
            string storage = null;
            string destFilePath = "output/DeleteParagraph_output.docx";
            paragraphsApi.DeleteParagraph(name, nodePath, index, folder, storage, password, destFilePath);
        }
        public static void GetParaChildObjects()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);
            var fileName = "getParaChildObjects.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int? index = 0;
            string folder = "input";
            string password = null;
            var response = paragraphsApi.GetParagraphChildObjects(name, nodePath, index, folder, password);
        }
        public static void GetParagraphformat()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);
            var fileName = "getParagraphformat.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int? index = 0;
            string folder = "input";
            string password = null;
            var response = paragraphsApi.GetParagraphFormat(name, nodePath, index, folder, password);
        }
        public static void UpdateParagraphFormat()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);
            var fileName = "updateParagraphFormat.docx";
            string name = fileName;
            string nodePath = "sections/0";
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
            paragraphsApi.UpdateParagraphFormat(name, nodePath, index, format, folder, storage, password, destFilePath);
        }
        public static void UpdateParagraphText()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);
            var fileName = "updateParagraphText.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int? index = 0;
            string text = "E-iceblue";
            string folder = "input";
            string password = null;
            string storage = null;
            string destFilePath = "output/UpdateParagraphText_output.docx";
            paragraphsApi.UpdateParagraphText(name, nodePath, index, text, folder, storage, password, destFilePath);
        }
    }
}
