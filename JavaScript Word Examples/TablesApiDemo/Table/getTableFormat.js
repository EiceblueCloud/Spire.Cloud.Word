(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var nodePath = "Section/0/Body/0";
    var opt = {folder: 'Tables'};
    var index = 0;
    instance.getTableFormat(filename, nodePath, index, opt,
    function (error, data, response) {
         if (error) throw error;
    });
})();