(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "AddTable.docx";
    var tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
    var opts = {
     folder: 'Tables'
    };
    var desFilePath = "output/Tables/AddTableCell_1.docx";
    instance.addTableCell(filename, tableRowPath, desFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();