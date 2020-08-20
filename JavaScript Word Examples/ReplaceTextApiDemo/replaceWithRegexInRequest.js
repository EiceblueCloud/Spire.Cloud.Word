(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ReplaceTextApi(apiClient);

    //upload the file from local disk
    var fs = require('fs');
    var filename = fs.createReadStream("C:/ReplaceWithRegexInRequest.docx");
    var regex = "\\#\\w+\\b";
    var newValue = "E-iceblue";
    var opts = {};
    instance.replaceWithRegexInRequest(filename, regex, newValue,opts, function (error, data, response) {
        if (error) throw error;
    });
})();