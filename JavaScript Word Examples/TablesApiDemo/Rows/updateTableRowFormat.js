(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var tablePath = "Section/0/Body/0/Table/0";
    var desFilePath = "output/Tables/updateTableRowFormat.docx";
    var index = 0;
    var format = new Spirecloudword.TableCellFormat();
    format.height = 100;
    format.heightType = "Exactly";
    format.breakAcrossPages = true;
    format.header = true;
    var opts = {folder: 'Tables'};
    instance.updateTableRowFormat(filename, tablePath, index, format, desFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();