(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.EncryptApi(apiClient);

    var fileName = "Template.docx";
    var destFilePath = 'output/EncryptDocument.docx';
    var password = "123";
    var opt = { folder: 'input', password: password };
    var response = instance.encryptDocument(fileName, destFilePath, opt, 
        function (error, data, response) {
            if (error) throw error;
        });
})();