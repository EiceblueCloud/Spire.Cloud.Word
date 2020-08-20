(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ProtectionApi(apiClient);

    //upload the file from local disk
    var fs = require('fs');
    var filename = fs.createReadStream("C:/ProtectDocumentInRequest.docx");
    //available types: AllowOnlyReading, AllowOnlyComments, AllowOnlyFormFields, AllowOnlyRevisions, NoProtection
    var protectionType = "AllowOnlyReading";
    var opts = {
        //docPassword: '123', //if input document has original password
        protectiongPwd: '123456'
    };
    instance.protectDocumentInRequest(filename, protectionType, opts, function (error, data, response) {
        if (error) throw error;
    });
})();