(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TextRangesApi(apiClient);

    var name = "Template.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var index = 0;
    var text = "E-iceblue test textRange";
    var destFilePath = "output/UpdateTextRangeText.docx";
    var opts = {
        folder: 'input',
        storage: null,
        password: null
    };
    instance.updateTextRangeText(name, paragraphPath, index, text, destFilePath, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();