import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ReplaceTextApi;
import java.io.File;
import java.io.FileNotFoundException;

public class ReplaceTextApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static ReplaceTextApi replaceTextApi = new ReplaceTextApi(wordConfiguration);
 
    public static void replaceWithRegex() throws ApiException {
        String name = "ReplaceText.docx";
        String regex = "\\#\\w+\\b";
        String newValue = "E-iceblue";
        String password = null;
        String folder = "input";
        String storage = null;
        String destFilePath = "output/ReplaceWithRegex_output.docx";
        replaceTextApi.replaceWithRegex(name, regex, newValue, destFilePath, password, folder, storage);
    }
    public static void replaceWithRegexInRequest() throws ApiException {
        String inputFilePath = "D:/inputFile/ReplaceText.docx";
        File inputFile = new File(inputFilePath);
        String regex = "\\#\\w+\\b";
        String newValue = "Spire.DOC";
        String password = null;
        File response = replaceTextApi.replaceWithRegexInRequest(inputFile, regex, newValue, password);
    }
    public static void replaceWithText() throws ApiException {
        String name = "ReplaceText.docx";
        String oldValue = "#test";
        String newValue = "Spire.DOC";
        String password = null;
        String folder = "input";
        String storage = null;
        Boolean matchCase = false;
        Boolean matchWholeWord = null;
        Boolean replaceFirst = null;
        String destFilePath = "output/ReplaceWithText_output.docx"; ;
        replaceTextApi.replaceWithText(name, oldValue, newValue, destFilePath, password, folder, storage, matchCase, matchWholeWord, replaceFirst);
    }
    public static void replaceWithTextInRequest() throws ApiException {
        String inputFilePath = "D:/inputFile/ReplaceText.docx";
        File inputFile = new File(inputFilePath);
        String oldValue = "#test";
        String newValue = "Spire.DOC";
        String password = null;
        Boolean matchCase = false;
        Boolean matchWholeWord = null;
        Boolean replaceFirst = null;
        File response = replaceTextApi.replaceWithTextInRequest(inputFile, oldValue, newValue, password, matchCase, matchWholeWord, replaceFirst);
    }
}
