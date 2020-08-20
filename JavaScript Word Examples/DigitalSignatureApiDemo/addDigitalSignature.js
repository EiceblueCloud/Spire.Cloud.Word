(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.DigitalSignatureApi(apiClient);

    var filename = "Template.docx";
    var fs = require('fs');
    var pfxFile = fs.createReadStream("D:/gary.pfx");
    var pfxFilePassword = "e-iceblue";
    var destFilePath = 'output/AddDigitalSignature.docx';
    var opt = { folder: 'input' };
    var response = instance.addDigitalSignature(filename, pfxFile, pfxFilePassword, destFilePath, opt, 
        function (error, data, response) {
            if (error) throw error;
        });
})();