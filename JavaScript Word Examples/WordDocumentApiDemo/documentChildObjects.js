(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.WordDocumentApi(apiClient);
    
    var filename = "GetDocumentChildObjects.docx";
    var opts = {
        folder: 'input',
        storage: '',
        password: ''
    };
    instance.getDocumentChildObjects(filename, opts, function (error, data, response) {
        if (error) throw error;
    });
})();