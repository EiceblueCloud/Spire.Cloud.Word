(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ConvertApi(apiClient);

    var name = "Convert.docx";
    var destFolder = "output/ConvertToHtml/";
    //If the document has no password, just remove the corresponding password parameter
    var opt = { 'folder': 'input' ,'password': '123'};
    instance.convertToHtml(name, destFolder, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();