using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudWord
{
    class MailMergeApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static MailMergeApi mailMergeApi = new MailMergeApi(wordConfiguration);
        public static void MailMerge()
        {
            string name = "mailMerge.doc";
            List<MailMergeData> data = new List<MailMergeData>();
            data.Add(new MailMergeData("Contact Name", "E-iceblue"));
            data.Add(new MailMergeData("Fax", "TestFax"));
            data.Add(new MailMergeData("Date", "2020-5-10"));
            string folder = "input";
            string storage = null;
            string password = null;
            string destFileName = "output/mailMerge_output.docx";
            mailMergeApi.MailMerge(name, destFileName, data, folder, storage, password);
        }

    }
}
