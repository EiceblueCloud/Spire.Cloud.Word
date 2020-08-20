(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.FieldsApi(apiClient);
    
    var fileName = "Fields.docx";
    var destFilePath = "output/Fields/UpdateField.docx";
    var opts = { 'folder': 'Fields' };
    instance.updateField(fileName, destFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();