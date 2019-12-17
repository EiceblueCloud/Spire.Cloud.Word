import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.FieldsApi;

public class FieldsApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void addField() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
        String name = "addField.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        String fieldCode = "DATE  \\@ \"h时m分s秒\"";
        String folder = "input";
        String storage = null;
        String password = null;
        Integer indexInParagraph = 0;
        String destFilePath = "output/addField_output.docx";
        fieldsApi.addField(name, paragraphPath, fieldCode, folder, storage, password, indexInParagraph, destFilePath);
    }

    public static void addMergeField() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
        String name = "addMergeField.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        String fieldName = "FiledTest";
        String folder = "input";
        String storage = null;
        String password = null;
        Integer indexInParagraph = 0;
        String fieldCode = null;
        String destFilePath = "output/addMergeField_output.docx";
        fieldsApi.addMergeField(name, paragraphPath, fieldName, folder, storage, password, indexInParagraph, fieldCode, destFilePath);
    }

    public static void deleteField() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
        String name = "deleteField.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/deleteField_output.docx";
        fieldsApi.deleteField(name, paragraphPath, index, folder, storage, password, destFilePath);
    }

    public static void updateField() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        FieldsApi fieldsApi = new FieldsApi(wordConfiguration);
        String name = "updateField.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/updateField_output.docx";
        fieldsApi.updateField(name, folder, storage, password, destFilePath);
    }
}
