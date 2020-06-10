import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.WordDocumentApi;
import spire.cloud.word.sdk.client.model.ObjectInfo;
import java.util.List;

public class WordDocumentApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static WordDocumentApi wordDocumentApi = new WordDocumentApi(wordConfiguration);

    public static void CreateDocument() throws ApiException {
        String fileFormat = "docx";//doc, rtf, wordml, docm, dotx, dot, dotm
        String name = "createDocument_output";
        String destFolder = "output";
        String storage = null;
        wordDocumentApi.createDocument(fileFormat, name, destFolder, storage);
    }
    public static void GetDocumentChildObjects() throws ApiException {
        String name = "template.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = wordDocumentApi.getDocumentChildObjects(name, folder, storage, password);
    }
}
