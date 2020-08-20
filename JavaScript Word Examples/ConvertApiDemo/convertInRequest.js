(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ConvertApi(apiClient);

    var fs = require('fs');
    var file = fs.createReadStream("D:/Convert.docx");
    var format = "pdf"; //Available values : doc, docx, wordml, wordxml, odt, docm, dotm, dotx, dot, rtf, pdf, xps, html, epub, pcl, postScript
    var opt = {};
    instance.convertInRequest(file, format, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();