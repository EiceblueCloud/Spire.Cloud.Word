using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;
using System.IO;

namespace CloudWord
{
    class ReplaceTextApiDemo
    {
        static String appId = "your id";
        static String appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static ReplaceTextApi replaceTextApi = new ReplaceTextApi(wordConfiguration);
        public static void ReplaceWithRegex()
        {
            string name = "ReplaceText.docx";
            string regex = @"\#\w+\b";
            string newValue = "E-iceblue";
            string password = null;
            string folder = "input";
            string storage = null;
            string destFilePath = "output/ReplaceWithRegex_output.docx";
            replaceTextApi.ReplaceWithRegex(name, regex, newValue, destFilePath, password, folder, storage);
        }
        public static void ReplaceWithRegexInRequest()
        {
            string inputFilePath = "D:/inputFile/ReplaceText.docx";
            System.IO.Stream inputFile = new FileStream(inputFilePath, FileMode.Open);
            string regex = @"\#\w+\b";
            string newValue = "Spire.DOC";
            string password = null;
            var response = replaceTextApi.ReplaceWithRegexInRequest(inputFile, regex, newValue, password);
        }
        public static void ReplaceWithText()
        {
            string name = "ReplaceText.docx";
            string oldValue = "#test";
            string newValue = "Spire.DOC";
            string password = null;
            string folder = "input";
            string storage = null;
            bool? matchCase = false;
            bool? matchWholeWord = null;
            bool? replaceFirst = null;
            string destFilePath = "output/ReplaceWithText_output.docx"; ;
            replaceTextApi.ReplaceWithText(name, oldValue, newValue, destFilePath, password, folder, storage, matchCase, matchWholeWord, replaceFirst);
        }
        public static void ReplaceWithTextInRequest()
        {
            string inputFilePath = "D:/inputFile/ReplaceText.docx";
            System.IO.Stream inputFile = new FileStream(inputFilePath, FileMode.Open);
            string oldValue = "#test";
            string newValue = "Spire.DOC";
            string password = null;
            bool? matchCase = false;
            bool? matchWholeWord = null;
            bool? replaceFirst = null;
            var response = replaceTextApi.ReplaceWithTextInRequest(inputFile, oldValue, newValue, password, matchCase, matchWholeWord, replaceFirst);
        }
    }
}
