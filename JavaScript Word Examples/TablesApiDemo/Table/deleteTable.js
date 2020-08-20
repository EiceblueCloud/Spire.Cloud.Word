(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var name = "Table.docx";
    var nodePath = "Section/0/Body/0";
    var index = 0;
    var opts = {
        storage: "",
        folder: 'Tables',
        password: null
    };
    var destFilePath = "output/Tables/DeleteTable.docx";
    instance.deleteTable(name, nodePath, index, destFilePath, opts,
    function (error, data, response) {
         if (error) throw error;
    });
    })();