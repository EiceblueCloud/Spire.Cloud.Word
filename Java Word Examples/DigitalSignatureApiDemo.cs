using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CloudWord
{
    class DigitalSignatureApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static DigitalSignatureApi digitalsignatureApi = new DigitalSignatureApi(wordConfiguration);
        public static void AddDigitalSignature()
        {
            string name = "addDigitalSignature.docx";
            Stream pfxFile = new FileStream("D:/inputFile/gary.pfx", FileMode.Open);
            string pfxFilePassword = "e-iceblue";
            string folder = "input";
            string destFilePath = "output/addDigitalSignature_output.docx";
            string storage = null;
            string docPassword = null;
            digitalsignatureApi.AddDigitalSignature(name, pfxFile, pfxFilePassword, destFilePath, folder, storage, docPassword);
        }
        public static void AddDigitalSignatureInRequest()
        {
            Stream docFile = new FileStream("D:/inputFile/addDigitalSignature.docx", FileMode.Open);
            Stream pfxFile = new FileStream("D:/inputFile/gary.pfx", FileMode.Open);
            string pfxFilePassword = "e-iceblue";
            string docPassword = null;
            var response = digitalsignatureApi.AddDigitalSignatureInRequest(docFile, pfxFile, pfxFilePassword, docPassword);
        }
    }
}
