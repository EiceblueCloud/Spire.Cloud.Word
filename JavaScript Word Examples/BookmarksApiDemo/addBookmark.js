(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.BookmarksApi(apiClient);
    
    var name = "AddBookmark.docx";
    var destFilePath = 'output/Bookmark/AddBookmark.docx';
    var startParagraphPath = "Section/0/Body/0/Paragraph/0";
    var startIndexInParagraph = 0;
    var endParagraphPath = "Section/0/Body/0/Paragraph/2";
    var endIndexInParagraph = 0;
    var bookmarkName = "newBookmark";
     var opt = {folder: 'bookmark'};
    var response = instance.addBookmark(name, startParagraphPath, startIndexInParagraph, endParagraphPath, endIndexInParagraph, bookmarkName, destFilePath, opt, 
        function (error, data, response) {
            if (error) throw error;
        });
})();