(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ConvertApi(apiClient);

    var name = "Convert.docx";
    var destFilePath = "output/ConvertToPdf.pdf";
    var opt = {};
    opt.folder = 'input';
    opt.privateFonts = [new Spirecloudword.PrivateFont()];
    opt.privateFonts[0].name = "黑体";
    opt.privateFonts[0].path = "input/consola.ttf";
    opt.privateFonts[0].embed = true;   
    instance.convertToPdf(name, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();