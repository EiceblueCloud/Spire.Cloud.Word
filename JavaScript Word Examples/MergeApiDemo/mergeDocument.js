(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.MergeApi(apiClient);

    var name = "Template.docx";
    var files = [
        new Spirecloudword.MergingFile(), new Spirecloudword.MergingFile(), new Spirecloudword.MergingFile()
    ];
    files[0].path = "input/Merge1.docx";
    files[1].path = "input/Merge2.doc";
    files[2].path = "input/Merge3.docx";
    var opt = { folder: 'input'};
    var destFilePath = 'output/MergeDocument.docx';
    instance.mergeDocument(name, files, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();