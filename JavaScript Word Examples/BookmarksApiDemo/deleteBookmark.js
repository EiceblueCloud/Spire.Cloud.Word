(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.BookmarksApi(apiClient);
    
    var name = "Bookmarks.docx";
    var destFilePath = 'output/Bookmark/DeleteBookmark.docx';
    var bookmarkName = "Test";
     var opt = {folder: 'bookmark'};
    var response = instance.deleteBookmark(name, bookmarkName, destFilePath, opt, 
        function (error, data, response) {
            if (error) throw error;
        });
})();