(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var index = 0;
    var tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
    var desFilePath = "output/Tables/DeleteTableCell_1.docx";
    var opts = {folder: 'Tables'};
    instance.deleteTableCell(filename, tableRowPath, index, desFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();