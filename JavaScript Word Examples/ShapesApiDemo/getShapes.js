(function (){
    var appId = "your id";
    var appKey = "your key";  
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ShapesApi(apiClient);

    var name = "Shape.docx";
    var opts = { folder: 'input','paragraphPath' :"Section/0/Body/0/Paragraph/0"};
    instance.getShapes(name, opts,
        function (error, data, response) {
            if (error) throw error;
        });
})();