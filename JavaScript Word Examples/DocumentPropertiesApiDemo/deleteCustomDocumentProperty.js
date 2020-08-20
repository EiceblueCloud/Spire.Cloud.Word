(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.DocumentPropertiesApi(apiClient);

    var filename = "DocumentProperties.docx";
    var propertieName_1 = "lastSavedB";
    var opt = { 'folder': "input" };
    var destFilePath = "output/DeleteCustomDocumentProperty.docx";   
    instance.deleteCustomDocumentProperty(filename, propertieName_1, destFilePath, opt, 
        function (error, data, response) {
            if (error) throw error;
        });
})();