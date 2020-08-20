(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ImagesApi(apiClient);

    var name = "Images.docx";
    var index = 0;
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var destFilePath = 'output/DeleteImage.docx';
    var opt = { folder: 'input'};
    instance.deleteImage(name, paragraphPath, index, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();