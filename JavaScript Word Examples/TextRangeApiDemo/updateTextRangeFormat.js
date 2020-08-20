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
    var textRange = new Spirecloudword.TextRangeFormat();
    textRange.font = new Spirecloudword.Font();
    textRange.font.fontSize = 30.0;
    textRange.font.fontName = "Aleo";
    textRange.font.color = new Spirecloudword.Color();
    textRange.font.color.red = 0;
    textRange.font.color.green = 255;
    textRange.font.color.blue = 255;
    var destFilePath = "output/UpdateTextRangeFormat.docx";
    var opt = {
        folder: 'input',
        indexInParagraph: null,
        storage: '',
        password: ''
    }
    
    instance.updateTextRangeFormat(name, paragraphPath, index, textRange, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();