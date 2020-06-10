import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.FieldsApi;
import spire.cloud.word.sdk.client.model.ObjectInfo;

import java.util.List;

public class FieldsApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static FieldsApi fieldsApi = new FieldsApi(wordConfiguration);

    public static void addField() throws ApiException {
        String name = "addField.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        String fieldCode = "DATE  \\@ \"h时m分s秒\"";
        String folder = "input";
        String storage = null;
        String password = null;
        Integer indexInParagraph = 0;
        String destFilePath = "output/addField_output.docx";
        fieldsApi.addField(name, paragraphPath, fieldCode, destFilePath, folder, storage, password, indexInParagraph);
    }

    public static void addMergeField() throws ApiException {
        String name = "addMergeField.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        String fieldName = "FiledTest";
        String folder = "input";
        String storage = null;
        String password = null;
        Integer indexInParagraph = 0;
        String fieldCode = null;
        String destFilePath = "output/addMergeField_output.docx";
        fieldsApi.addMergeField(name, paragraphPath, fieldName, destFilePath, folder, storage, password, indexInParagraph, fieldCode);
    }

    public static void deleteField() throws ApiException {
        String name = "deleteField.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/deleteField_output.docx";
        fieldsApi.deleteField(name, paragraphPath, index, destFilePath, folder, storage, password);
    }

    public static void getFields() throws ApiException {
        String name = "getFields.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        String paragraphPath = null;
        List<ObjectInfo> response = fieldsApi.getFields(name, folder, storage, password, paragraphPath);
    }

    public static void updateField() throws ApiException {
        String name = "updateField.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/updateField_output.docx";
        fieldsApi.updateField(name, folder, storage, password, destFilePath);
    }
}
