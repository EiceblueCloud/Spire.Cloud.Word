(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var index = 5;
    var format = new Spirecloudword.TableCellFormat();
    format.width = 100;
    format.backgroundColor = new Spirecloudword.Color();
    format.backgroundColor.red = 100;
    format.backgroundColor.green = 100;
    format.backgroundColor.blue = 100;
    var tableRowPath = "Section/0/Body/0/Table/0/TableRow/3";
    var desFilePath = "output/Tables/UpdateTableCellFormat.docx";
    var opts = { folder: 'Tables' }
    instance.updateTableCellFormat(filename, tableRowPath, index, format, desFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();