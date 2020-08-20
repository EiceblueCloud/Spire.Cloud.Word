(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ConvertApi(apiClient);

    var name = "Convert.docx";
    var format = "postScript"; //Available values : doc, docx, wordml, wordxml, odt, docm, dotm, dotx, dot, rtf, pdf, xps, html, epub, pcl, postScript
    var destFilePath = 'output/Convert.ps';
    var opt = { 'folder': 'input' };
    var response = instance.convert(name, format, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();