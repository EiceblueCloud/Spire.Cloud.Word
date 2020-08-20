(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.DigitalSignatureApi(apiClient);

    var fs = require('fs');
    var file = fs.createReadStream("D:/Template.docx");
    var pfxFile = fs.createReadStream("D:/gary.pfx");
    var pfxFilePassword = "e-iceblue";
    var opts = {};
    opts.password = null;
    var response = instance.addDigitalSignatureInRequest(file, pfxFile, pfxFilePassword, opts, 
        function (error, data, response) {
            if (error) throw error;
        });
})();