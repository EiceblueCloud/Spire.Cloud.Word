import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.DocumentPropertiesApi;
import spire.cloud.word.sdk.client.model.*;

import java.util.*;

public class DocumentPropertiesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static DocumentPropertiesApi documentPropertiesApi = new DocumentPropertiesApi(wordConfiguration);

    public static void addCustomDocumentProperties() throws ApiException {
        String name = "addCustomDocumentProperties.docx";
        List<CustomDocumentProperty> properties = new ArrayList<CustomDocumentProperty>();
        properties.add(new CustomDocumentProperty("propertiesName1", "propertiesValue1"));
        properties.add(new CustomDocumentProperty("propertiesName2", "propertiesValue2"));
        String password = null;
        String folder = "input";
        String destFilePath = "output/addCustomDocumentProperties_out.docx";
        String storage = null;
        documentPropertiesApi.addCustomDocumentProperties(name, properties, destFilePath, password, folder, storage);
    }

    public static void deleteCustomDocumentProperty() throws ApiException {
        String name = "deleteCustomDocumentPropertie.docx";
        String propertieName = "E-iceblue";
        String password = null;
        String folder = "input";
        String storage = null;
        String destFilePath = "output/deleteCustomDocumentProperties_output.docx";
        documentPropertiesApi.deleteCustomDocumentProperty(name, propertieName, destFilePath, password, folder, storage);
    }

    public static void getBuiltinDocumentProperties() throws ApiException {
        String name = "getBuiltinDocumentProperties.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        BuiltinDocumentProperties response = documentPropertiesApi.getBuiltinDocumentProperties(name, password, folder, storage);
    }

    public static void getCustomDocumentProperties() throws ApiException {
        String name = "getCustomDocumentProperties.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        List<CustomDocumentProperty> response = documentPropertiesApi.getCustomDocumentProperties(name, password, folder, storage);
    }
}
