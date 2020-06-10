import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.EncryptApi;

import java.io.File;
import java.util.stream.Stream;

public class EncryptApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static EncryptApi encryptApi = new EncryptApi(wordConfiguration);

    public static void encryptDocument() throws ApiException {
        String name = "encryptDocument.docx";
        String folder = "input";
        String oldPassword = null;
        String newPassword = "123456";
        String destFilePath = "output/encryptDocument_output.docx";
        String storage = null;
        encryptApi.encryptDocument(name, destFilePath, folder, storage, oldPassword, newPassword);
    }

    public static void encryptDocumentInRequest() throws ApiException {
        File inputFile = new File("D:/inputFile/encryptDocument.docx");
        String oldPassword = null;
        String newPassword = "123456";
        encryptApi.encryptDocumentInRequest(inputFile, oldPassword, newPassword);
    }
}
