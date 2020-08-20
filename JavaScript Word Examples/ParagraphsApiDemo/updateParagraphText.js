(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ParagraphsApi(apiClient);

    var filename = "UpdateParagraphText.docx";
    var nodePath = "Section/0/Body/0";
    var opt = {
        folder: 'input',
    };
    var index = 0;
    var text = "Updated Paragraph 2 ";
    var deFilePath = "output/UpdateParagraphText_ouput.docx";
    instance.updateParagraphText(filename, nodePath, index, text, deFilePath, opt, function (error, data, response) {
        if (error) throw error;    
    });
})();