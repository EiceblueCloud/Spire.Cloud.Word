(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TextRangesApi(apiClient);

    var filename = "AddTextRange.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var destFilePath = "output/AddTextRange_out.docx";
    var text = "AddTextRange";
    var opt = {
        folder: 'input',
        indexInParagraph: null,
        storage: '',
        password: ''
    }    
    instance.addTextRange(filename, paragraphPath, text, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();