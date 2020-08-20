(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ConvertApi(apiClient);

    var name = "Convert.docx";
    var imageType = "wmf"; //Available values : wmf, svg
    var destFolder = 'output/ConvertToVectorgraph_WMF/';
    var opt = { 'folder': 'input' };
    instance.convertToVectorgraph(name, imageType, destFolder, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();