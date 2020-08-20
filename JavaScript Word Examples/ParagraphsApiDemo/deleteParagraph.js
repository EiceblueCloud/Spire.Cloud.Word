(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ParagraphsApi(apiClient);

    var filename = "DeleteParagraph.docx";
    var nodePath = "Section/0/Body/0";
    var opt = {
        folder: 'input',
    };
    var index = 1;
    var destFilePath = "output/DeleteParagraph_output.docx";
    instance.deleteParagraph(filename, nodePath, index, destFilePath, opt, function (error, data, response) {
        if (error) throw error;
        });
})();