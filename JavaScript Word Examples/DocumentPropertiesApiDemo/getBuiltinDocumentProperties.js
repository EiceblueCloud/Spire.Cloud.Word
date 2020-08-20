(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.DocumentPropertiesApi(apiClient);

    var filename = "GetBuiltinDocumentProperties.docx";
    var opt = { 'folder': "input" };
    var response = instance.getBuiltinDocumentProperties(filename, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();