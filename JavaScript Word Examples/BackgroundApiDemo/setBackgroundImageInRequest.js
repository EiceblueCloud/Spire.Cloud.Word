(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.BackgroundApi(apiClient);
    
    var name = "AddBackground.docx";
    var destFilePath = 'output/Background/SetBackgroundImageInRequest.docx';
    var fs = require('fs');
    var imageData = fs.createReadStream("D:/Images/Hydrangeas.jpg");
     var opt = {folder: 'background'};
    var response = instance.setBackgroundImageInRequest(name, imageData, destFilePath, opt,
        function (error, data, response) {        
            if (error) throw error;
        });
})();