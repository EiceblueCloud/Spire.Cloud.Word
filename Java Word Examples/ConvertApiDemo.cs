using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace CloudWord
{
    class ConvertApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
        static ConvertApi convertApi = new ConvertApi(wordConfiguration);
        public static void Convert()
        {
            string name = "convert.docx";
            string format = "xps";//postScript, pcl, dot, dotx, dotm, docm, odt, wordxml, wordml, pdf, doc, docx, rtf, epub, xps, html
            string password = null;
            string folder = "input";
            string storage = null;
            string destFilePath = "output/convert_output.xps" ;
            convertApi.Convert(name, format, destFilePath, password, folder, storage);
        }
        public static void ConvertInRequest()
        {
            string inputFilePath = "D:/inputFile/convert.docx";
            string format = "postScript";//postScript, pcl, dot, dotx, dotm, docm, odt, wordxml, wordml, pdf, doc, docx, rtf, epub, xps, html
            string password = null;
            System.IO.Stream inputfile = new FileStream(inputFilePath, FileMode.Open);
            convertApi.ConvertInRequest(inputfile, format, password);
        }
        public static void ConvertToBitmap()
        {
            string name = "convertToBitmap.docx";
            string imageFormat = "jpeg";//jpeg, bmp, png
            string password = null;
            string folder = "input";
            string storage = null;
            int? startPage = null;
            int? pageCount = null;
            string destFolder = "output/bitmap/";
            convertApi.ConvertToBitmap(name, imageFormat, destFolder, password, folder, storage, startPage, pageCount);
        }
        public static void ConvertToBitmapInRequest()
        {
            Stream inputFile = new FileStream("D:/inputFile/convertToBitmapInRequest.docx", FileMode.Open);
            string imageFormat = "jpeg";//jpeg, bmp, png
            string password = null;
            int? startPage = null;
            int? pageCount = null;
            var response = convertApi.ConvertToBitmapInRequest(inputFile, imageFormat, password, startPage, pageCount);
        }
        public static void ConvertToHtml()
        {
            string name = "convertToHtml.docx";
            string password = null;
            string folder = "input";
            string storage = null;
            string destFolder = "output/convertToHtml";
            convertApi.ConvertToHtml(name, destFolder, password, folder, storage);
        }
        public static void ConvertToHtmlInRequest()
        {
            Stream inputFile = new FileStream("D:/inputFile/convertInRequest.docx", FileMode.Open);
            string password = null;
            var response = convertApi.ConvertToHtmlInRequest(inputFile, password);
        }
        public static void ConvertToPdf()
        {
            string name = "convertToPdf.docx";
            string password = null;
            string folder = "input";
            string storage = null;
            string destFilePath = "output/convertToPdf_out.pdf"; ;
            var privateFonts = new List<PrivateFont>();
            privateFonts.Add(new PrivateFont("黑体", "input/simhei.ttf",true));
            privateFonts.Add(new PrivateFont("consola", "input/consola.ttf", true));
            convertApi.ConvertToPdf(name, destFilePath, password, folder, storage, privateFonts);
        }
        public static void ConvertToVectorgraph()
        {
            string name = "convertToVectorgraph.docx";
            string imageType = "wmf";//wmf, svg
            string password = null;
            string folder = "input";
            string storage = null;
            int? startPage = null;
            int? pageCount = null;
            string destFolder = "output/vectorgraph/";
            convertApi.ConvertToVectorgraph(name, imageType, destFolder, password, folder, storage, startPage, pageCount);
        }
        public static void ConvertToVectorgraphInRequest()
        {
            Stream inputFile = new FileStream("D:/inputFile/convertToVectorgraphInRequest.docx", FileMode.Open);
            string imageType = "wmf";//wmf, svg
            string password = null;
            int? startPage = null;
            int? pageCount = null;
            convertApi.ConvertToVectorgraphInRequest(inputFile, imageType, password, startPage, pageCount);
        }
    }
}
