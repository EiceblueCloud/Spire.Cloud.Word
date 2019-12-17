import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.EncryptApi;

public class EncryptApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void encryptDocument() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        EncryptApi encryptApi = new EncryptApi(wordConfiguration);
        String name = "encryptDocument.docx";
        String folder = "input";
        String oldPassword = null;
        String newPassword = "123456";
        String destFilePath = "output/encryptDocument_output.docx";
        String storage = null;
        encryptApi.encryptDocument(name, folder, storage, oldPassword, newPassword, destFilePath);
    }
}
