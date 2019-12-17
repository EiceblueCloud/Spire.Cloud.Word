import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.TextRangesApi;
import spire.cloud.word.sdk.client.model.TextRangeFormat;

public class TextRangesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
   
    public static void addTextRange() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TextRangesApi api = new TextRangesApi(wordConfiguration);
        String name ="addTextRange.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        TextRangeFormat textRange = new TextRangeFormat();
        textRange.text("Test textRange");
        String folder = "input";
        String storage = null;
        Integer indexInParagraph = 0;
        String password = null;
        String destFilePath ="output/addTextRange_output.docx";
        api.addTextRange(name, paragraphPath, textRange, folder, storage, indexInParagraph, password, destFilePath);
    }
    public static void deleteTextRange() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TextRangesApi api = new TextRangesApi(wordConfiguration);
        String name ="deleteTextRange.docx";
        String paragraphPath ="sections/0/paragraphs/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/deleteTextRange_output.docx";
        api.deleteTextRange(name, paragraphPath, index, folder, storage, password, destFilePath);
    }
    public static void getTextRangeProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TextRangesApi api = new TextRangesApi(wordConfiguration);
        String name  ="getTextRangeProperties.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TextRangeFormat response = api.getTextRangeProperties(name, paragraphPath, index, folder, storage, password);
    }
    public static void updateTextRange() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TextRangesApi api = new TextRangesApi(wordConfiguration);
        String name  ="updateTextRange.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        Integer index = 0;
        TextRangeFormat textRange = new TextRangeFormat();
        textRange.text("Test textRange");
        textRange.backgroundColor(new spire.cloud.word.sdk.client.model.Color());
        textRange.getBackgroundColor().blue(100);
        textRange.getBackgroundColor().red(200);
        textRange.getBackgroundColor().green(10);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/updateTextRange_output.docx";
        api.updateTextRange(name, paragraphPath, index, textRange, folder, storage, password, destFilePath);
    }
}
