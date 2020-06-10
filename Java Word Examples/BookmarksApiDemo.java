import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.*;
import spire.cloud.word.sdk.client.model.BookmarkInfo;

import java.util.List;

public class BookmarksApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static BookmarksApi bookmarksApi = new BookmarksApi(wordConfiguration);
    
    public static void addBookmark() throws ApiException {
        String name = "addBookmark.docx";
        String startParagraphPath = "sections/0/paragraphs/0";
        int startIndexInParagraph = 0;
        String endParagraphPath = "sections/0/paragraphs/0";
        int endIndexInParagraph = 2;
        String password = null;
        String bookmarkName = "Test_bookmark";
        String folder = "input";
        String destFilePath = "output/addBookmark_output.docx";
        String storage = null;
        bookmarksApi.addBookmark(name, startParagraphPath, startIndexInParagraph, endParagraphPath,
                endIndexInParagraph, bookmarkName, destFilePath, folder, storage, password);
    }

    public void deleteBookmark() throws Exception {
        String name = "deleteBookmark.docx";
        String storage = null;
        String folder = "Bookmark";
        String bookmarkName = "Test";
        String password = null;
        String destFilePath = "output/deleteBookmark_out.docx";
        bookmarksApi.deleteBookmark(name, bookmarkName, destFilePath, folder, storage, password);
    }


    public static void getBookmarkContent() throws ApiException {
        String name = "getBookmarkContent.docx";
        String bookmarkName = "Test";
        String folder = "input";
        String password = null;
        String storage = null;
        String response = bookmarksApi.getBookmarkContent(name, bookmarkName, folder, storage, password);
    }

    public static void getBookmarks() throws ApiException {
        String name = "getBookmarks.docx";
        String folder = "input";
        String password = null;
        String storage = null;
        List<BookmarkInfo> response = bookmarksApi.getBookmarks(name, folder, storage, password);
    }
}
