(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.BackgroundApi(apiClient);
    
    var name = "AddBackground.docx";
    var color = new Spirecloudword.Color();
    color.red = 127;
    color.green = 255;
    color.blue = 170;
    var destFilePath = 'output/Background/SetBackgroundColor.docx';
     var opt = {folder: 'background'};
    var response = instance.setBackgroundColor(name, color, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();