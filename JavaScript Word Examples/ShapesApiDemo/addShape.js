(function (){
    var appId = "your id";
    var appKey = "your key";  
    
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ShapesApi(apiClient);

    var fileName = "Template.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/2";
    var tempVar = new Spirecloudword.ShapeFormat();
    tempVar.width = 40;
    tempVar.height = 40;
    tempVar.shapeType = "Rectangle";
    tempVar.horizontalOrigin = "Page";
    tempVar.verticalOrigin = "Paragraph";
    tempVar.verticalPosition = 50.0;
    tempVar.horizontalPosition = 150.0;
    tempVar.fillColor = new Spirecloudword.Color();
    tempVar.fillColor.red = 0;
    tempVar.fillColor.green = 206;
    tempVar.fillColor.blue = 209;
    tempVar.rotation = 45.0;
    tempVar.strokeWeight = 2;
    tempVar.strokeColor = new Spirecloudword.Color();
    tempVar.strokeColor.red = 173;
    tempVar.strokeColor.green = 255;
    tempVar.strokeColor.blue = 47;
    tempVar.textWrappingType = "Both";
    tempVar.textWrappingStyle = "InFrontOfText";
    tempVar.zOrder = 1;
    var shapeProperties = tempVar;
    var opts = { folder: 'input', indexInParagraph: '0' };
    var destFilePath = "output/AddShape_out.docx";
    instance.addShape(fileName, paragraphPath, shapeProperties, destFilePath, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();