using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.IO;

namespace CloudWord
{
    class ImagesApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static ImagesApi imagesApi = new ImagesApi(wordConfiguration);
        public static void AddImage()
        {
            string name = "addImage.docx";
            string imagePath = "input/image.png";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            string folder = "input";
            string storage = null;
            string password = null;
            int? indexInParagraph = 0;
            string destFilePath = "output/addImage_out.docx";
            imagesApi.AddImage(name, imagePath, paragraphPath, destFilePath, folder, storage, password, indexInParagraph);
        }

        public static void AddImageInRequest()
        {
            string name = "addImage.docx";
            Stream inputImage = new FileStream("../../inputFile/image.png", FileMode.Open);
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            string folder = "input";
            string storage = null;
            string password = null;
            int? indexInParagraph = 0;
            string destFilePath = "output/addImage_out.docx";
            imagesApi.AddImageInRequest(name, inputImage, paragraphPath, destFilePath, folder, storage, password, indexInParagraph);
        }

        public static void DeleteImage()
        {
            string name = "deleteImage.docx"; ;
            string paragraphPath = "Section/0/Body/0/Paragraph/1";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/addImage_out.docx";
            imagesApi.DeleteImage(name, paragraphPath, index, destFilePath, folder, storage, password);
        }
        public static void GetImageFormat()
        {
            string name = "getImageFormat.docx"; ;
            string paragraphPath = "Section/0/Body/0/Paragraph/1";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            imagesApi.GetImageFormat(name, paragraphPath, index, password, folder, storage);
        }
        public static void GetImages()
        {
            string name = "getImages.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/1";
            string folder = "input";
            string storage = null;
            string password = null;
            imagesApi.GetImages(name, password, folder, storage, paragraphPath);
        }
        public static void UpdateImageFormat()
        {
            string name = "updateImageFormat.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/1";
            int? index = 0;
            var format = new ImageFormat()
            {
                Width = 400,
                Height = 400,
                Rotation = 20,
                VerticalPosition = 50,
                HorizontalPosition = 50
            };
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/updateImageFormat_out.docx";
            imagesApi.UpdateImageFormat(name, paragraphPath, index, destFilePath, format, password, folder, storage);
        }
    }
}
