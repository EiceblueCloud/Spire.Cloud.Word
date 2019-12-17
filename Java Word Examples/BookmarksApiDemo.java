import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.BookmarksApi;

public class BookmarksApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    
    public static void addBookmark() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        BookmarksApi bookmarksApi = new BookmarksApi(wordConfiguration);
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
                endIndexInParagraph, bookmarkName, folder, storage, password, destFilePath);
    }

    public static void getBookmarkContent() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        BookmarksApi bookmarksApi = new BookmarksApi(wordConfiguration);
        String name = "getBookmarkContent.docx";
        String bookmarkName = "Test";
        String folder = "input";
        String password = null;
        String storage = null;
        String response = bookmarksApi.getBookmarkContent(name, bookmarkName, folder, storage, password);
    }
}
