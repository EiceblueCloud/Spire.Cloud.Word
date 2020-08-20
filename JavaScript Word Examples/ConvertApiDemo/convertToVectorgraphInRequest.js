(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ConvertApi(apiClient);

    var fs = require('fs');
    var file = fs.createReadStream("D:/Convert.docx");
    var imageType = "wmf"; //Available values :  wmf, svg
    var opt = {};
    instance.convertToVectorgraphInRequest(file,imageType,opt, 
        function (error, data, response) {
            if (error) throw error;
        });
})();