using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpireDocCloudDemo
{
    class MailMergeApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void MailMerge()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            MailMergeApi mailMergeApi = new MailMergeApi(wordConfiguration);
            string name = "mailMerge.doc";
            List<MailMergeData> data = new List<MailMergeData>();
            data.Add(new MailMergeData("Contact Name", "E-iceblue"));
            data.Add(new MailMergeData("Fax", "TestFax"));
            data.Add(new MailMergeData("Date", "2019-10-16"));
            string folder = "input";
            string storage = null;
            string password = null;
            string destFileName = "output/mailMerge_output.docx";
            mailMergeApi.MailMerge(name, data, folder, storage, password, destFileName);
        }

    }
}
