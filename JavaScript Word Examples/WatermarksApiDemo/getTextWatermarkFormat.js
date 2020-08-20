(function (){
    var appId = "your id";
    var appKey = "your key";  
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.WatermarksApi(apiClient);

    var name = "TextWatermark.doc";
    var opts = {
        folder: 'input',
        storage: '',
        password: ''
    };
    instance.getTextWatermarkFormat(name, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();