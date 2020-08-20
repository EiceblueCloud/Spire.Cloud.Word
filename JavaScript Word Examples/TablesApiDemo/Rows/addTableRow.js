(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var tablePath = "Section/0/Body/0/Table/0";
    var opts = {
        folder: 'Tables',
        indexOfTableRow: 0,
        cellsCount: 4
    };
    var desFilePath = "output/Tables/AddTableRow_1.docx";
    instance.addTableRow(filename, tablePath, desFilePath,opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();