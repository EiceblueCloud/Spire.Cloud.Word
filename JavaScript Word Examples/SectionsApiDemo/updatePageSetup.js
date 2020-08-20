(function (){
    var appId = "your id";
    var appKey = "your key";  
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.SectionsApi(apiClient);

    var fileName = "PageSetup.docx";
    var sectionIndex = 0;
    var pageSetup = new Spirecloudword.PageSetup();
    pageSetup.pageWidth = 400.0;
    pageSetup.pageHeight = 500.0;
    pageSetup.pageMargin = new Spirecloudword.Margin();
    pageSetup.pageMargin.top = 20.0;
    pageSetup.pageMargin.bottom = 20.0;
    pageSetup.pageMargin.left = 20.0;
    pageSetup.pageMargin.right = 20.0;
    pageSetup.linenumber = new Spirecloudword.LineNumber();
    pageSetup.linenumber.startValue = 1;
    pageSetup.linenumber.step = 2;
    pageSetup.linenumber.restartMode = "Continuous";
    pageSetup.linenumber.distanceFromText = 20;
    pageSetup.orientation = "Landscape";
    var destFilePath = 'output/UpdatePageSetup.docx';
    var opts = { folder: 'input' };
    instance.updatePageSetup(fileName, sectionIndex, pageSetup, destFilePath, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();