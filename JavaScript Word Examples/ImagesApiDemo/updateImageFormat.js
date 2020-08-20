(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ImagesApi(apiClient);

    var name = "Images.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/1";
    var index = 0;
    var folder="input"
    var format = new Spirecloudword.ImageFormat();
    format.width = 400;
    format.height = 400;
    format.rotation = 20;
    format.horizontalPosition = 50;
    format.verticalPosition = 50;
    var destFilePath = 'output/UpdateImageFormat.docx';
    var opt = { folder: 'input' };
    instance.updateImageFormat(name, paragraphPath, index, destFilePath, format, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();