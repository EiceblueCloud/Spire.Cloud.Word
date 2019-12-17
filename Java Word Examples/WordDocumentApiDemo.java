import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.WordDocumentApi;

public class WordDocumentApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void createDocument() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        WordDocumentApi wordDocumentApi = new WordDocumentApi(wordConfiguration);
        String fileFormat = "docx";
        String name = "createDocument_output";
        String destFolder = "output";
        String storage = null;
        wordDocumentApi.createDocument(fileFormat, name, destFolder, storage);
    }
}
