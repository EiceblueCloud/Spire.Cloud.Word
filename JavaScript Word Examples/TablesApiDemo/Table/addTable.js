(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient);
    
    var filename = "Table.docx";
    var nodePath = "Section/0/Body/0";
    var rowsCount = 6;
    var columnsCount = 6;
    var destFilePath = "output/Tables/AddTable_1.docx";
    var opts = {
        storage: "",
        folder: 'Tables',
        indexOfTable: 0,
        password: null
    };
    instance.addTable(filename, nodePath, rowsCount, columnsCount, destFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
})();