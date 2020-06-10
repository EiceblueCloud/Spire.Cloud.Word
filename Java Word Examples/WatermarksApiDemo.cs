using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.IO;

namespace CloudWord
{
    class WatermarksApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static WatermarksApi watermarksApi = new WatermarksApi(wordConfiguration);
        public static void DeleteWatermark()
        {         
            string fileName = "deleteWatermark.docx";
            string folder = "input";
            string storage = null;
            string password =null;
            string destFilePath = "output/deleteWatermark_output.docx";
            watermarksApi.DeleteWatermark(fileName, destFilePath, folder, storage, password);
        }
        public static void GetTextWatermarkFormat()
        {
            string fileName = "getTextWatermarkFormat.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            var response = watermarksApi.GetTextWatermarkFormat(fileName, folder, storage, password);
        }
        public static void SetImageWatermark()
        {
            string fileName = "setImageWatermark.docx";
            string imagePath = "images/Background.png";
            string folder = "input";
            string storage = null;
            int? scaling = 120;
            bool washout = true;
            string password = null;
            string destFilePath = "output/setImageWatermark_output.docx";
            watermarksApi.SetImageWatermark(fileName, imagePath, destFilePath,folder, storage, scaling, washout, password);
        }
        public static void SetImageWatermarkInRequest()
        {
            string name = "watermark.docx";
            string inputFilePath = "D:/inputFile/Background.png";
            System.IO.Stream inputImage = new FileStream(inputFilePath, FileMode.Open);
            string folder = "input";
            string storage = null;
            int? scaling = 120;
            bool washout = false;
            string password = null;
            string destFilePath = "output/setImageWatermarkInRequest_output.docx";
            watermarksApi.SetImageWatermarkInRequest(name, inputImage, destFilePath, folder, storage, scaling, washout, password);
        }
        public static void SetTextWatermark()
        {
            string name = "setTextWatermark.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            TextWatermark body = new TextWatermark("E-iceblue")
            {
                Layout = TextWatermark.LayoutEnum.Horizontal,
                Font = new Font(60, "Arial")
                {
                    Color = new Color(100, 100, 100)
                }
            };
            string destFilePath = "output/setTextWatermark_output.docx";
            watermarksApi.SetTextWatermark(name, body, destFilePath, folder, storage, password);
        }
    }
}
