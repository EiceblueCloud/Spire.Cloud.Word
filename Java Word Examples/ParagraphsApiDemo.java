import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ParagraphsApi;
import spire.cloud.word.sdk.client.model.*;
import java.util.List;


public class ParagraphsApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
   
    public static void addParagraph() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ParagraphsApi api = new ParagraphsApi(wordConfiguration);
        String name ="addParagraph.docx";
        String nodePath =  "sections/0";
        String folder = "input";
        String storage = null;
        Integer indexOfParagraph = 1;
        String password = null;
        String text = "Test Paragraph";
        String destFilePath ="output/addParagraph_output.docx";
        api.addParagraph(name, nodePath, folder, storage, indexOfParagraph, password, text, destFilePath);
    }
    public static void deleteParagraph() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ParagraphsApi api = new ParagraphsApi(wordConfiguration);
        String name ="deleteParagraph.docx";
        String nodePath = "sections/0";;
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/deleteParagraph_output.docx";
        api.deleteParagraph(name, nodePath, index, folder, storage, password, destFilePath);
    }
    public static void getParagraphChildObjects() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ParagraphsApi api = new ParagraphsApi(wordConfiguration);
        String name ="getParagraphChildObjects.docx";
        String nodePath ="sections/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = api.getParagraphChildObjects(name, nodePath, index, folder, storage, password);
    }
    public static void getParagraphFormat() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ParagraphsApi api = new ParagraphsApi(wordConfiguration);
        String name="getParagraphFormat.docx";
        String nodePath =  "sections/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        ParagraphFormat response = api.getParagraphFormat(name, nodePath, index, folder, storage, password);
    }
    public static void updateParagraphFormat() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ParagraphsApi api = new ParagraphsApi(wordConfiguration);
        String name ="updateParagraphFormat.docx";
        String nodePath = "sections/0";
        Integer index = 0;
        ParagraphFormat format = new ParagraphFormat();
        format.afterAutoSpacing(true);
        Color backgroundColor=new Color();
        backgroundColor.red(100);
        backgroundColor.green(100);
        backgroundColor.blue(100);
        format.backgroundColor(backgroundColor);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/updateParagraphFormat_output.docx";
        api.updateParagraphFormat(name, nodePath, index, format, folder, storage, password, destFilePath);
    }
    public static void updateParagraphText() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ParagraphsApi api = new ParagraphsApi(wordConfiguration);
        String name ="updateParagraphText.docx";
        String nodePath = "sections/0";
        Integer index = 0;
        String text = "Test text";
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/updateParagraphText_output.docx";
        api.updateParagraphText(name, nodePath, index, text, folder, storage, password, destFilePath);
    }
}
