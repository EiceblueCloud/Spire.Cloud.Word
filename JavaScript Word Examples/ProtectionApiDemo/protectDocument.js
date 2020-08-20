(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ProtectionApi(apiClient);

    var filename = "ProtectDocument.docx";
    //available types: AllowOnlyReading, AllowOnlyComments, AllowOnlyFormFields, AllowOnlyRevisions, NoProtection
    var protectionType = "AllowOnlyReading";
    var opts = {
        folder: 'input',
        //docPassword: '123', //if input document has original password
        protectiongPwd: '123456'
    };
    var destFilePath = 'output/ProtectDocument_output.docx';
    instance.protectDocument(filename, protectionType, destFilePath, opts, function (error, data, response) {
        if (error) throw error;  
    });
})();