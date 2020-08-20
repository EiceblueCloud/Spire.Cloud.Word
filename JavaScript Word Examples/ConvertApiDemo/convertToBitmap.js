(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ConvertApi(apiClient);

    var name = "Convert.docx";
    var imageFormat = "jpeg"; //Available values : jpeg, bmp, png
    var destFolder = 'output/ConvertToBitmap_jpeg/';
    var opt = { 'folder': 'input' };
    instance.convertToBitmap(name, imageFormat, destFolder, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();