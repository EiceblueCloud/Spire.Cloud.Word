import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ProtectionApi;
import java.io.File;
import java.io.FileNotFoundException;

public class ProtectionApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static ProtectionApi protectionApi = new ProtectionApi(wordConfiguration);

        public static void protectDocument() throws ApiException {
            String fileName = "Template.docx";
            String name = fileName;
            String protectionType = "AllowOnlyReading"; //AllowOnlyComments,AllowOnlyFormFields,AllowOnlyRevisions,NoProtection
            String folder = "input";
            String storage = null;
            String docPassword = null;
            String protectiongPwd = "123456";
            String destFilePath = "output/Template_output.docx" ;
            protectionApi.protectDocument(name, protectionType, destFilePath, folder, storage, docPassword, protectiongPwd);
        }
        public static void protectDocumentWithFile() throws FileNotFoundException, ApiException {
            String inputFilePath = "D:/inputFile/Template.docx";
            File inputFile= new File(inputFilePath);
            String protectionType = "AllowOnlyReading"; //AllowOnlyComments,AllowOnlyFormFields,AllowOnlyRevisions,NoProtection
            String docPassword = null;
            String protectiongPwd = "123456";
            File response = protectionApi.protectDocumentInRequest(inputFile, protectionType, docPassword, protectiongPwd);
        }
}
