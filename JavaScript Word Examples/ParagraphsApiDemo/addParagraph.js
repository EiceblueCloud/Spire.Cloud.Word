(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ParagraphsApi(apiClient);

    var filename = "AddParagraph.docx";
    var nodePath = "Section/0/Body/0";
    var opts = {
        folder: 'input',
        indexOfParagraph: 0,
        text: "E-iceblue"
    };
    var destFilePath = "output/AddParagraph_output.docx";
    instance.addParagraph(filename, nodePath, destFilePath, opts, function (error, data, response) {
        if (error) throw error;
        });
})();