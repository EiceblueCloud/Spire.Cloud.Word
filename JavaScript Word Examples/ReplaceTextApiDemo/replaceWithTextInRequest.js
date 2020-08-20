(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ReplaceTextApi(apiClient);

    //upload the file from local disk
    var fs = require('fs');
    var filename = fs.createReadStream("C:/ReplaceWithTextInRequest.docx");
    var oldValue = "Test";
    var newValue = "E-iceblue";
    var opt = { matchCase: "false" };
    instance.replaceWithTextInRequest(filename, oldValue, newValue, opt, function (error, data, response) {
        if (error) throw error;
    });
})();