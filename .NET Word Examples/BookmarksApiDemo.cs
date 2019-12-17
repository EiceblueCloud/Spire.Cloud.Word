using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using System;

namespace SpireDocCloudDemo
{
    class BookmarksApiDemo
    {
        static string appId = "your id";
        static string appKey = "your key";

        public static void AddBookmark()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            BookmarksApi bookmarksApi = new BookmarksApi(wordConfiguration);
            string name = "addBookmark.docx";
            string startParagraphPath = "sections/0/paragraphs/0";
            int startIndexInParagraph = 0;
            string endParagraphPath = "sections/0/paragraphs/0";
            int endIndexInParagraph = 2;
            string password = null;
            string bookmarkName = "Test_bookmark";
            string folder = "input";
            string destFilePath = "output/addBookmark_output.docx";
            string storage = null;
            bookmarksApi.AddBookmark(name, startParagraphPath, startIndexInParagraph, endParagraphPath,
                endIndexInParagraph, bookmarkName, folder, storage, password, destFilePath);
        }

        public static void GetBookmarkContent()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            BookmarksApi bookmarksApi = new BookmarksApi(wordConfiguration);
            string name = "getBookmarkContent.docx";
            string bookmarkName = "Test";
            string folder = "input";
            string password = null;
            string storage = null;
            var response = bookmarksApi.GetBookmarkContent(name, bookmarkName, folder, storage, password);
        }
    }
}
