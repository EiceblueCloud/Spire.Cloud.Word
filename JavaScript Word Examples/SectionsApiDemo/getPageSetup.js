(function (){
    var appId = "your id";
    var appKey = "your key";  
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.SectionsApi(apiClient);

    var fileName = "PageSetup.docx";
    var sectionIndex = 2;
    var opt = { folder: 'input' };
    instance.getPageSetup(fileName, sectionIndex, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();