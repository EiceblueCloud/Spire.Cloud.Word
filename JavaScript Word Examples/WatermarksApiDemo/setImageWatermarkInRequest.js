(function (){
    var appId = "your id";
    var appKey = "your key"; 
    
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.WatermarksApi(apiClient);

    var name = "Template.docx";
    var fs = require('fs');
    var file = fs.createReadStream("D://data//Logo.png");
    var destFilePath = "output/SetImageWatermarkInRequest_out.docx";
    var opts = {
        folder: 'input',
        storage: null,
        scaling: 120,
        washout: true,
        password: null
    };
    instance.setImageWatermarkInRequest(name, inputImage, destFilePath, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();