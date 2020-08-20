(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ReplaceTextApi(apiClient);

    var filename = "ReplaceWithRegex.docx";
    var regex = "\\#\\w+\\b";
    var newValue = 'E-iceblue';
    var destFilePath = 'output/ReplaceWithRegex_output.docx';
    var opt = { folder: 'input' };
    instance.replaceWithRegex(filename, regex, newValue, destFilePath, opt, function (error, data, response) {
        if (error) throw error;
    });
})();