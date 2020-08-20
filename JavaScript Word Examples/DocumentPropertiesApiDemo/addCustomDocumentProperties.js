(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.DocumentPropertiesApi(apiClient);

    var filename = "Template.docx";
    var properties = [new Spirecloudword.CustomDocumentProperty("Keywords", "Set document properties.", "string"),
                    new Spirecloudword.CustomDocumentProperty("Author", "eiceblue"),
                    new Spirecloudword.CustomDocumentProperty("Company", "冰蓝"),
                    new Spirecloudword.CustomDocumentProperty("LastSavedBy", "123456@iCloud.com"),
                    new Spirecloudword.CustomDocumentProperty("SharedDoc", "true", "boolean"),
                    new Spirecloudword.CustomDocumentProperty("Date", "2019/1/30", "datetime"),
                    new Spirecloudword.CustomDocumentProperty("Number", "8", "number"),];
    var destFilePath = "output/AddCustomDocumentProperties.docx";
    var opt = { 'folder': "input", 'properties': properties };
    instance.addCustomDocumentProperties(filename, properties, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();