using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class ShapesApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string basePath = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, basePath);
        static ShapesApi shapesApi = new ShapesApi(wordConfiguration);
        public static void AddShape()
        {         
            string name = "addShape.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int indexInParagraph = 1;
            string folder = "input";
            string storage = null;
            string password = null;
            ShapeFormat shapeFormat = new ShapeFormat(40, 40, ShapeFormat.ShapeTypeEnum.Rectangle)
            {
                HorizontalOrigin = ShapeFormat.HorizontalOriginEnum.Page,
                VerticalOrigin = ShapeFormat.VerticalOriginEnum.Page,
                VerticalPosition = 200,
                HorizontalPosition = 100,
                FillColor = new Color(100, 100, 100),
                Rotation = 45,
                StrokeWeight = 2,
                StrokeColor = new Color(125, 125, 125),
                TextWrappingType = ShapeFormat.TextWrappingTypeEnum.Both,
                TextWrappingStyle = ShapeFormat.TextWrappingStyleEnum.InFrontOfText,
                ZOrder = 1
            };
            string destFilePath = "output/addShape_output.docx";
            shapesApi.AddShape(name, paragraphPath, shapeFormat, destFilePath,folder, storage, indexInParagraph, password);
        }

        public static void DeleteShape()
        {
            string name = "deleteShape.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/deleteShape_output.docx";
            shapesApi.DeleteShape(name, paragraphPath, index, destFilePath, folder, storage, password);
        }
        public static void GetShapeFormat()
        {
            string name = "template.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0"; ;
            int? index = 3;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = shapesApi.GetShapeFormat(name, paragraphPath, index, folder, storage, password);
        }
        public static void GetShapes()
        {
            string name = "getShapes.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            string paragraphPath = null;
            var response = shapesApi.GetShapes(name, folder, storage, password, paragraphPath);
        }
        public static void UpdateShapeFormat()
        {
            string name = "updateShapeFormat.docx";
            string paragraphPath = "Section/0/Body/0/Paragraph/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            ShapeFormat shapeFormat = new ShapeFormat(40, 40, ShapeFormat.ShapeTypeEnum.Rectangle)
            {
                HorizontalOrigin = ShapeFormat.HorizontalOriginEnum.Page,
                VerticalOrigin = ShapeFormat.VerticalOriginEnum.Page,
                VerticalPosition = 200,
                HorizontalPosition = 100,
                FillColor = new Color(100, 100, 100),
                Rotation = 95,
                StrokeWeight = 1,
                StrokeColor = new Color(225, 15, 15),
                TextWrappingType = ShapeFormat.TextWrappingTypeEnum.Both,
                TextWrappingStyle = ShapeFormat.TextWrappingStyleEnum.InFrontOfText,
                ZOrder = 1
            };
            string destFilePath = "output/updateShapeFormat_output.docx";
            shapesApi.UpdateShapeFormat(name, paragraphPath, index, shapeFormat, destFilePath, folder, storage, password);
        }
    }
}
