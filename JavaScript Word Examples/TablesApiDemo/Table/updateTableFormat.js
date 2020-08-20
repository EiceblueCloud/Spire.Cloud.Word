(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.TablesApi(apiClient); 

    var filename = "Table.docx";
    var index = 0;
    var nodePath = "Section/0/Body/0";
    var format = new Spirecloudword.TableFormat();
    format.bidi=true;
    format.borders = new Spirecloudword.Borders();
    format.borders.topBorder=new Spirecloudword.Border();
    format.borders.topBorder.borderType="Dot"; //Available types: Dot, Double, ThinThickThinMediumGap
    format.borders.topBorder.color=new Spirecloudword.Color();
    format.borders.topBorder.color.red=255;
    format.borders.topBorder.color.green=25;
    format.borders.topBorder.color.blue=1;
    format.borders.topBorder.lineWidth=3;
    var opt = {folder: 'Tables'};
    var destFilePath = "output/Tables/UpdateTableFormat_1.docx";
    instance.updateTableFormat(filename, nodePath, index, format, destFilePath, opt,
    function (error, data, response) {
         if (error) throw error;
    });
})();