(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ReplaceTextApi(apiClient);

    var filename = "ReplaceWithText.docx";
    var oldValue = "Paragraph 1";
    var newValue = "E-iceblue";
    var destFilePath = 'output/ReplaceWithText_output.docx';
    var opt = { folder: 'input', matchCase: true, matchWholeWord: false, replaceFirst: true};
    instance.replaceWithText(filename, oldValue, newValue, destFilePath, opt, function (error, data, response) {
        if (error) throw error;
    });
})();