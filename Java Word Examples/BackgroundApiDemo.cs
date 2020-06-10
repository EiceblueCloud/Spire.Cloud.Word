using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CloudWord
{
    class BackgroundApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey,baseUrl);
        static BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);

        public static void DeleteBackground()
        {
            string name = "deleteBackground.docx";
            string password = null;
            string folder = "input";
            string destFilePath = "output/deleteBackground_output.docx";
            string storage = null;
            backgroundApi.DeleteBackground(name, destFilePath, password, folder, storage);
        }
        public static void GetBackgroudColor()
        {
            string name = "getBackgroundColor.docx";
            string password = null;
            string folder = "input";
            var response =  backgroundApi.GetBackgroundColorAsync(name, password, folder);
        }

        public static void SetBackgroudColor()
        {
            string name = "setBackgroundColor.docx";
            Color color = new Color(127, 255, 170);
            string password = null;
            string folder = "input";
            string destFilePath = "output/setBackgroundColor_output.docx";
            string storage = null;
            backgroundApi.SetBackgroundColor(name, color, destFilePath, folder, storage, password);
        }
        public static void SetBackgroudImage()
        {
            string name = "setBackgroundImage.docx";
            string imagePath = "input/background.png";
            string password = null;
            string folder = "input";
            string destFilePath = "output/setBackgroundImage_output.docx";
            string storage = null;
            backgroundApi.SetBackgroundImage(name, imagePath, destFilePath, folder, storage, password);
        }
        public static void SetBackgroundImageInRequest()
        {
            string name = "setBackgroundImageInRequest.docx";
            string folder = "input";
            string password = null;
            string storage = null;
            string imagePath = "../../inputFile/background.png";
            System.IO.Stream Imagefs = new FileStream(imagePath, FileMode.Open);
            string destFilePath = "output/setBackgroundImageInRequest_output.docx"; ;
            backgroundApi.SetBackgroundImageInRequest(name, Imagefs, destFilePath, folder, storage, password);
        }
    }
}
