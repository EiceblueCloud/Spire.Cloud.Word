(function (){
    var appId = "your id";
    var appKey = "your key";    
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ShapesApi(apiClient);

    var fileName = "Shape.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var index = 0;
    var tempVar = new Spirecloudword.ShapeFormat();
    tempVar.width = 50;
    tempVar.height = 50;
    tempVar.shapeType = "Octagon";
    tempVar.horizontalOrigin = "LeftMarginArea";
    tempVar.verticalOrigin = "Paragraph";
    tempVar.verticalPosition = 80.0;
    tempVar.horizontalPosition = 80.0;
    tempVar.fillColor = new Spirecloudword.Color();
    tempVar.fillColor.red = 100;
    tempVar.fillColor.green = 100;
    tempVar.fillColor.blue = 100;
    tempVar.rotation = 0;
    tempVar.strokeWeight = 2;
    tempVar.strokeColor = new Spirecloudword.Color();
    tempVar.strokeColor.red = 0;
    tempVar.strokeColor.green = 206;
    tempVar.strokeColor.blue = 209;
    tempVar.textWrappingType = "Both";
    tempVar.textWrappingStyle = "InFrontOfText";
    tempVar.zOrder = 1;
    var shapeProperties = tempVar;
    var opts = { folder: 'input' };
    var destFilePath = "output/UpdateShapeFormat_out.docx";
    instance.updateShapeFormat(fileName, paragraphPath, index, shapeProperties, destFilePath, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();