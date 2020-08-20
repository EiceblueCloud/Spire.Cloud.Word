(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.WordDocumentApi(apiClient);
    
    //available formats: docx, doc, rtf, wordml, docm, dotx, dot, dotm
    var format = "docx";
    var name = "CreateDocument";
    var destFolder = 'output';
    var opts = { storage: "" };
    instance.createDocument(format, name, destFolder, opts, function (error, data, response) {
        if (error) throw error;
    });
})();