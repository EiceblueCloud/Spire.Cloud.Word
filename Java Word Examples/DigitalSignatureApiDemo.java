import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.DigitalSignatureApi;

import java.io.File;

public class DigitalSignatureApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static DigitalSignatureApi digitalsignatureApi = new DigitalSignatureApi(wordConfiguration);

    public static void addDigitalSignature() throws ApiException {
        String name = "addDigitalSignature.docx";
        File pfxFile = new File("D:/inputFile/gary.pfx");
        String pfxFilePassword = "e-iceblue";
        String folder = "input";
        String destFilePath = "output/addDigitalSignature_output.docx";
        String storage = null;
        String docPassword = null;
        digitalsignatureApi.addDigitalSignature(name, pfxFile, pfxFilePassword, destFilePath, folder, storage, docPassword);
    }

    public static void addDigitalSignatureInRequest() throws ApiException {
        File docFile = new File("D:/inputFile/addDigitalSignature.docx");
        File pfxFile = new File("D:/inputFile/gary.pfx");
        String pfxFilePassword = "e-iceblue";
        String docPassword = null;
        File response = digitalsignatureApi.addDigitalSignatureInRequest(docFile, pfxFile, pfxFilePassword, docPassword);
    }
}
