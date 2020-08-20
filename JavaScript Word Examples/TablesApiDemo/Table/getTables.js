(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var opts = {
        folder: 'Tables',
        storage: '',
        password: '',
        nodePath: "Section/0/Body/0"
    };
    instance.getTables(filename, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();