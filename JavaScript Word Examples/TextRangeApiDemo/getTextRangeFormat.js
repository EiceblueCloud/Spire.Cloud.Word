(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TextRangesApi(apiClient);

    var filename = "GetTextRangeFormat.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var index = 0;
    var opt = {
        folder: 'input',
        storage: '',
        password: ''
    }
    instance.getTextRangeFormat(filename, paragraphPath, index, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();