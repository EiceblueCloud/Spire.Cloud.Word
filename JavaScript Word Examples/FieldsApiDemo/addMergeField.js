(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.FieldsApi(apiClient);
    
    var fileName = "AddField.docx";
    var paragraph_path = "Section/0/Body/0/Paragraph/0";
    var destFilePath = "output/Fields/AddMergeField_1.docx";
    var fieldName = 'FieldTest';
    var opts = { 'folder': 'input', 'indexInParagraph': 0 };
    instance.addMergeField(fileName, paragraph_path, fieldName, destFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();