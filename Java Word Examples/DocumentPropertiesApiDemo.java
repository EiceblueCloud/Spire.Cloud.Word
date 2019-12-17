import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.DocumentPropertiesApi;
import spire.cloud.word.sdk.client.model.*;
import java.util.ArrayList;
import java.util.List;

public class DocumentPropertiesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void addCustomDocumentProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
        String name = "addCustomDocumentProperties.docx";
        CustomDocumentProperty customDocumentPropertie1=new CustomDocumentProperty();
        customDocumentPropertie1.name("testName1");
        customDocumentPropertie1.value("testValue1");
        CustomDocumentProperty customDocumentPropertie2=new CustomDocumentProperty();
        customDocumentPropertie2.name("testName2");
        customDocumentPropertie2.value("testValue2");
        List<CustomDocumentProperty> properties = new ArrayList<>();
        properties.add(customDocumentPropertie1);
        properties.add(customDocumentPropertie2);
        String password = null;
        String folder = "input";
        String destFilePath = "output/addCustomDocumentProperties_out.docx";
        String storage = null;
        documentPropertiesApi.addCustomDocumentProperties(name, properties, password, folder, storage, destFilePath);
    }

    public static void deleteCustomDocumentProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
        String name = "deleteCustomDocumentProperties.docx";
        String propertieName = "E-iceblue";
        String password = null;
        String folder = "input";
        String storage = null;
        String destFilePath = "output/deleteCustomDocumentProperties_output.docx";
        documentPropertiesApi.deleteCustomDocumentProperties(name, propertieName, password, folder, storage, destFilePath);
    }

    public static void getBuiltinDocumentProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
        String name = "getBuiltinDocumentProperties.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        BuiltinDocumentProperties response = documentPropertiesApi.getBuiltinDocumentProperties(name, password, folder, storage);
    }

    public static void getCustomDocumentProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);
        String name = "getCustomDocumentProperties.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        List<CustomDocumentProperty> response = documentPropertiesApi.getCustomDocumentProperties(name, password, folder, storage);
    }
}
