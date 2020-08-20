(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.FieldsApi(apiClient);
    
    var fileName = "Fields.docx";
    var paragraph_path = "Section/0/Body/0/Paragraph/0";
    var destFilePath = "output/Fields/DeleteField_1.docx";
    var index = 0;
    var opts = { 'folder': 'Fields' };
    instance.deleteField(fileName, paragraph_path, index, destFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();