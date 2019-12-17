using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SpireDocCloudDemo
{
    class BackgroundApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void DeleteBackground()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
            string name = "deleteBackground.docx";
            string password = null;
            string folder = "input";
            string destFilePath = "output/deleteBackground_output.docx";
            string storage = null;
            backgroundApi.DeleteBackground(name, password, folder, storage, destFilePath);
        }

        public static void GetBackgroudColor()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
            string name = "getBackgroundColor.docx";
            string password = null;
            string folder = "input";
            string storage = null;
            var response =  backgroundApi.GetBackgroudColorAsync(name, password, folder, storage);
        }

        public static void SetBackgroudColor()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
            string name = "setBackgroundColor.docx";
            Color color = new Color(255, 1, 1);
            string password = null;
            string folder = "input";
            string destFilePath = "output/setBackgroundColor_output.docx";
            string storage = null;
            backgroundApi.SetBackgroudColor(name, color, folder, storage, password, destFilePath);
        }

        public static void SetBackgroudImage()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
            string name = "setBackgroundImage.docx";
            string imagePath = "input/Background.png";
            string password = null;
            string folder = "input";
            string destFilePath = "output/setBackgroundImage_output.docx";
            string storage = null;
            backgroundApi.SetBackgroudImage(name, imagePath, folder, storage, password, destFilePath);
        }

        public static void SetBackgroudImageWithImgFile()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
            string name = "setBackgroundImageWithImgFile.docx";
            Stream inputImage = new FileStream("../../inputFile/Background.png", FileMode.Open);
            string password = null;
            string folder = "input";
            string destFilePath = "output/setBackgroundImageWithImgFile_output.docx";
            string storage = null;
            backgroundApi.SetBackgroundImageWithImgFile(name, inputImage, folder, storage, password, destFilePath);
        }
    }
}
