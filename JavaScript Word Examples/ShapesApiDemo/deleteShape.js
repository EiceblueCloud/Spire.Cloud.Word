(function (){
    var appId = "your id";
    var appKey = "your key";  
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ShapesApi(apiClient);

    var fileName = "DeleteShape.docx";
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var index = 1;
    var destFilePath = "output/DeleteShape_out.docx";
    var opts = { folder: 'input' };
    instance.deleteShape(fileName, paragraphPath, index, destFilePath, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();