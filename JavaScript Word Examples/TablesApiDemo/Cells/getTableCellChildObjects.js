(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var tableRowPath ="Section/0/Body/0/Table/0/TableRow/0";
    var index = 0;
    var opt = {folder: 'Tables'};
    instance.getTableCellChildObjects(filename, tableRowPath, index,opt,
    function (error, data, response) {
         if (error) throw error;
    });
})();