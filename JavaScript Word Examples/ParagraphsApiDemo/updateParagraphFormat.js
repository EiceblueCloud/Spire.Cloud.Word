(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ParagraphsApi(apiClient);

    var filename = "UpdateParagraphFormat.docx";
    var nodePath = "Section/0/Body/0";
    var opt = {
        folder: 'input',
    };
    var desFilePath = "output/UpdateParagraphFormat_output.docx";
    var index = 0;
    var format = new Spirecloudword.ParagraphFormat();
    format.horizontalAlignment = 'Distribute';
    format.leftOrInnerIndent = 20;
    format.rightOrOutsideIndent = 10;
    format.mirrorIndents = false;
    format.firstLineIndent = 30;
    format.backgroundColor = new Spirecloudword.Color();
    format.backgroundColor.red = 100;
    format.backgroundColor.green = 100;
    format.backgroundColor.blue = 100;
    format.beforeSpacing = 40;
    format.afterSpacing = 40;
    format.beforeAutoSpacing = false;
    format.afterAutoSpacing - false;
    format.lineSpace = 50;
    format.lineSpacingRule = "Exactly";
    format.wordWrap = true;
    format.borders = new Spirecloudword.Borders();
    format.borders.topBorder = new Spirecloudword.Border();
    format.borders.topBorder.borderType ="Double";
    instance.updateParagraphFormat(filename, nodePath, index, format, desFilePath, opt, function (error, data, response) {
        if (error) throw error;     
    });
})();