(function (){
    var appId = "your id";
    var appKey = "your key";  
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.WatermarksApi(apiClient);

    var name = "Template.docx";
    var body = new Spirecloudword.TextWatermark();
    body.text = "E-iceblue";
    body.layout = "Horizontal";
    body.font = new Spirecloudword.Font();
    body.font.fontSize = 60;
    body.font.fontName = "Cooper Black";
    body.font.color = new Spirecloudword.Color();
    body.font.color.red = 100;
    body.font.color.green = 100;
    body.font.color.blue = 100;
    var destFilePath = "output/SetTextWatermark_out.docx";
    var opts = {
        folder: 'input',
        storage: null,
        password: null
    };
    instance.setTextWatermark(name, body, destFilePath, opts, 
        function (error, data, response) {
            if (error) throw error;
        });
})();