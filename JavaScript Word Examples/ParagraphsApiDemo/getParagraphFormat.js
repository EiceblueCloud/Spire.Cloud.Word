(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ParagraphsApi(apiClient);

    var filename = "GetParagraphFormat.docx";
    var nodePath = "Section/0/Body/0";
    var opt = {
        folder: 'input'
    };
    var index = 0;
    instance.getParagraphFormat(filename, nodePath, index, opt, function (error, data, response) {
        if (error) throw error;
    });
})();
