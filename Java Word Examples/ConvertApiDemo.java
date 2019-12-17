import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ConvertApi;
import java.io.File;

public class ConvertApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    
    public static void convertDocumentWithFile() throws ApiException{
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ConvertApi convertApi = new ConvertApi(wordConfiguration);
        File inputfile = new File("inputFile/convertDocumentWithFile.docx");
        String format = "pdf";
        String password = null;
        File response = convertApi.convertDocumentWithFile(inputfile, format, password);
    }

    public static void convertDocument() throws ApiException{
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ConvertApi convertApi = new ConvertApi(wordConfiguration);
        String name = "convertDocument.docx";
        String format = "xps";
        String password = null;
        String folder = "input";
        String storage = null;
        String destFilePath = "output/convertDocument_output.xps";
        convertApi.convertDocument(name, format, password, folder, storage, destFilePath);
    }
}
