using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class SectionsApiDemo
    {
        static String appId = "your id";
        static String appKey = "your key";
        public static void GetPageSetup()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            SectionsApi sectionsApi = new SectionsApi(wordConfiguration);
            var fileName = "GetPageSetup.docx";
            string name = fileName;
            int? sectionIndex = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = sectionsApi.GetPageSetup(name, sectionIndex, folder, storage, password);
        }
        public static void GetSectionObjects()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            SectionsApi sectionsApi = new SectionsApi(wordConfiguration);
            var fileName = "getSectionObjects.docx";
            string name = fileName;
            int? sectionIndex = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = sectionsApi.GetSectionObjects(name, sectionIndex, folder, storage, password);
        }
        public static void UpdatePageSetup()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            SectionsApi sectionsApi = new SectionsApi(wordConfiguration);
            var fileName = "updatePageSetup.docx";
            string name = fileName;
            int? sectionIndex = 0;
            string storage = null;
            var marging = new Margin(20, 20, 20, 20);
            var linenumber = new LineNumber(1, 2, LineNumber.RestartModeEnum.Continuous, 20);
            PageSetup pageSetup = new PageSetup(400, 500, marging, PageSetup.OrientationEnum.Landscape, linenumber);
            string folder = "input";
            string password = null;
            string destFilePath = "output/UpdatePageSetup_output.docx";
            sectionsApi.UpdatePageSetup(name, sectionIndex, pageSetup, folder, storage, password, destFilePath);
        }
    }
}
