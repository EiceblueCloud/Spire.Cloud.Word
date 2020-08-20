(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.BackgroundApi(apiClient);
    
    var name = "BackgroundDoc.docx";
    var opt = {folder: 'background'};
    var response = instance.getBackgroundColor(name, opt,
        function (error, data, response) {        
            if (error) throw error;
        });
})();