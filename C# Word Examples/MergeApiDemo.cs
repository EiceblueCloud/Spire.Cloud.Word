using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.Collections.Generic;

namespace CloudWord
{
    class MergeApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string basePath= "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, basePath);
        static MergeApi mergeApi = new MergeApi(wordConfiguration);
        public static void MergeDocument()
        {          
            string name = "mergeDocument1.docx";
            List<MergingFile> files = new List<MergingFile>() {
                new MergingFile("input/mergeDocument2.docx", null, null)
            };
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/mergeDocument_output.docx";
            mergeApi.MergeDocument(name, files, destFilePath, folder, storage, password);          
        }
    }
}
