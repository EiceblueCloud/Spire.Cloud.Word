using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;

namespace CloudWord
{
    class BookmarksApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";
        static string baseUrl = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey,baseUrl);
        static BookmarksApi bookmarksApi = new BookmarksApi(wordConfiguration);
        public static void AddBookmark()
        {
            string name = "addBookmark.docx";
            string startParagraphPath = "Section/0/Body/0/Paragraph/0";
            int startIndexInParagraph = 0;
            string endParagraphPath = "Section/0/Body/0/Paragraph/2";
            int endIndexInParagraph = 2;
            string password = null;
            string bookmarkName = "Text_bookmark";
            string folder = "input";
            string destFilePath = "output/addBookmark_output.docx";
            string storage = null;
            bookmarksApi.AddBookmark(name, startParagraphPath, startIndexInParagraph, endParagraphPath,
                endIndexInParagraph, bookmarkName, destFilePath, folder, storage, password);
        }
        public static void DeleteBookmark()
        {
            string name = "deleteBookmark.docx";
            string bookmarkName = "Text_bookmark";
            string folder = "input";
            string password = null;
            string storage = null;
            string destFilePath = "output/deleteBookmark_output.docx";
            bookmarksApi.DeleteBookmark(name, bookmarkName, destFilePath, folder, storage, password);
        }
        public static void GetBookmarkContent()
        {
            string name = "getBookmarkContent.docx";
            string bookmarkName = "Test";
            string folder = "input";
            string password = null;
            var response = bookmarksApi.GetBookmarkContent(name, bookmarkName, folder, password);
        }
        public static void GetBookmarks()
        {
            string name = "getBookmarks.docx";
            string folder = "input";
            string password = null;
            string storage = null;
            var response = bookmarksApi.GetBookmarks(name, folder, storage, password);
        }
    }
}
