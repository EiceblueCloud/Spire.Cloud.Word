using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class SectionsApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static SectionsApi sectionsApi = new SectionsApi(wordConfiguration);
        public static void AddSection()
        {
            string name = "template.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            int? sectionIndex = null;
            string destFilePath = "output/addSection_output.docx";
            sectionsApi.AddSection(name, destFilePath, folder, storage, password, sectionIndex);
        }
        public static void GetPageSetup()
        {          
            string name = "getPageSetup.docx";
            int? sectionIndex = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = sectionsApi.GetPageSetup(name, sectionIndex, folder, storage, password);
        }
        public static void GetSectionChildObjects()
        {
            string name = "getSectionChildObjects.docx"; ;
            int? sectionIndex = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = sectionsApi.GetSectionChildObjects(name, sectionIndex, folder, storage, password);
        }
        public static void GetSections()
        {
            string name = "template.docx"; ;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = sectionsApi.GetSections(name, folder, storage, password);
        }
        public static void UpdatePageSetup()
        {
            string name = "updatePageSetup.docx"; ;
            int? sectionIndex = 0;
            string storage = null;
            var marging = new Margin(20, 20, 20, 20);
            var linenumber = new LineNumber(1, 2, LineNumber.RestartModeEnum.Continuous, 20);
            PageSetup pageSetup = new PageSetup(400, 500, marging, PageSetup.OrientationEnum.Landscape, linenumber);
            string folder = "input";
            string password = null;
            string destFilePath = "output/updatePageSetup_output.docx";
            sectionsApi.UpdatePageSetup(name, sectionIndex, pageSetup, destFilePath,folder, storage, password);
        }
    }
}
