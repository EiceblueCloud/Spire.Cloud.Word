using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.IO;

namespace CloudWord
{
    class WatermarksApiDemo
    {
        static String appId = "your id";
        static String appKey = "your key";
        public static void DeleteWatermark()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            WatermarksApi watermarksApi = new WatermarksApi(wordConfiguration);
            string fileName = "deleteWatermark.docx";
            string folder = "input";
            string storage = null;
            string password =null;
            string destFilePath = "output/DeleteWatermark_output.docx";
            watermarksApi.DeleteWatermark(fileName, folder, storage, password, destFilePath);
        }
        public static void GetTextWatermarkProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            WatermarksApi watermarksApi = new WatermarksApi(wordConfiguration);
            string fileName = "getTextWatermarkProperties.docx";
            string folder = "input";
            string password = null;
            var response = watermarksApi.GetTextWatermarkProperties(fileName, folder, password);
        }
        public static void SetImageWatermarkOnLine()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            WatermarksApi watermarksApi = new WatermarksApi(wordConfiguration);
            string fileName = "setImageWatermarkOnLine.docx";
            string inputFilePath = "D:/inputFile/Background.png";
            System.IO.Stream inputImage = new FileStream(inputFilePath, FileMode.Open);
            string folder = "input";
            string storage = null;
            int? scaling = 120;
            bool washout = false;
            string password = null;
            string destFilePath = "output/SetImageWatermarkOnLine_output.docx";
            watermarksApi.SetImageWatermarkOnLine(fileName, inputImage, folder, storage, scaling, washout, password, destFilePath);
        }
        public static void SetImageWatermark()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            WatermarksApi watermarksApi = new WatermarksApi(wordConfiguration);
            var fileName = "setImageWatermark.docx";
            string name = fileName;
            string imagePath = "input/Background.png";
            string folder = "input";
            string storage = null;
            int? scaling = 120;
            bool? washout = true;
            string password = null;
            string destFilePath = "output/SetImageWatermark_output.docx";
            watermarksApi.SetImageWatermark(name, imagePath, folder, storage, scaling, washout, password, destFilePath);
        }
        public static void SetTextWatermark()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            WatermarksApi watermarksApi = new WatermarksApi(wordConfiguration);
            var fileName = "setTextWatermark.docx";
            string name = fileName;
            string folder = "input";
            string storage = null;
            string password = null;
            TextWatermark body = new TextWatermark("E-iceblue")
            {
                Layout = TextWatermark.LayoutEnum.Horizontal,
                Font = new Font(60, "宋体")
                {
                    Color = new Color(100, 100, 100)
                }
            };
            string destFilePath = "output/SetTextWatermark_output.docx";
            watermarksApi.SetTextWatermark(name, body, folder, storage, password, destFilePath);
        }
    }
}
