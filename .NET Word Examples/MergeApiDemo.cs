using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.Collections.Generic;

namespace SpireDocCloudDemo
{
    class MergeApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void MergeDocument()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            MergeApi mergeApi = new MergeApi(wordConfiguration);
            string name = "mergeDocument1.docx";
            List<MergingFile> files = new List<MergingFile>() {
                new MergingFile("mergeDocument2.docx", "input", null)
            };
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/mergeDocument_output.docx";
            mergeApi.MergeDocument(name, files, folder, storage, password, destFilePath);
        }
    }
}
