(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.BackgroundApi(apiClient);
    
    var name = "AddBackground.docx";
    var destFilePath = 'output/Background/SetBackgroundImage.docx';
    var imagePath = "background/Hydrangeas.jpg";
     var opt = {folder: 'background'};
    var response = instance.setBackgroundImage(name, imagePath, destFilePath, opt,
        function (error, data, response) {        
            if (error) throw error;
        });
})();