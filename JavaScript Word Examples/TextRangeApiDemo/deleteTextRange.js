(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TextRangesApi(apiClient);

    var filename = "DeleteTextRange.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var destFilePath = "output/DeleteTextRange_out.docx";
    var index = 0;
    var opt = {
        folder: 'input',
        storage: '',
        password: ''
    }
    instance.deleteTextRange(filename, paragraphPath, index, destFilePath, opt, 
        function (error, data, response) {
            if (error) throw error;
        });
})();