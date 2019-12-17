using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace SpireDocCloudDemo
{
    class ShapesApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void AddShape()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ShapesApi shapesApi = new ShapesApi(wordConfiguration);
            string name = "addShape.docx";
            string paragraphPath = "sections/0/paragraphs/0";
            int indexInParagraph = 1;
            string folder = "input";
            string storage = null;
            string password = null;
            ShapeFormat shapeProperties = new ShapeFormat(40, 40, ShapeFormat.ShapeTypeEnum.Rectangle)
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
            shapesApi.AddShape(name, paragraphPath, shapeProperties, folder, storage, indexInParagraph, password, destFilePath);
        }

        public static void DeleteShape()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ShapesApi shapesApi = new ShapesApi(wordConfiguration);
            string name = "deleteShape.docx";
            string paragraphPath = "sections/0/paragraphs/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/deleteShape_output.docx";
            shapesApi.DeleteShape(name, paragraphPath, index, folder, storage, password, destFilePath);
        }
        public static void GetShapeProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ShapesApi shapesApi = new ShapesApi(wordConfiguration);
            string name = "getShapeProperties.docx";
            string paragraphPath = "sections/0/paragraphs/0"; ;
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = shapesApi.GetShapeProperties(name, paragraphPath, index, folder, storage, password);
        }

        public static void UpdateShapeProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            ShapesApi shapesApi = new ShapesApi(wordConfiguration);
            string name = "updateShapeProperties.docx";
            string paragraphPath = "sections/0/paragraphs/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            ShapeFormat shapeProperties = new ShapeFormat(40, 40, ShapeFormat.ShapeTypeEnum.Rectangle)
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
            string destFilePath = "output/updateShapeProperties_output.docx";
            shapesApi.UpdateShapeProperties(name, paragraphPath, index, shapeProperties, folder, storage, password, destFilePath);
        }
    }
}
