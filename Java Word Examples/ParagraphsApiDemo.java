import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ParagraphsApi;
import spire.cloud.word.sdk.client.model.*;
import java.util.List;

public class ParagraphsApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static ParagraphsApi paragraphsApi = new ParagraphsApi(wordConfiguration);

    public static void addParagraph () throws ApiException {
        String fileName = "addParagraph.docx";
        String name = fileName;
        String nodePath = "Section/0/Body/0";
        Integer indexOfParagraph = 1;
        String folder = "input";
        String password = null;
        String text = "E-iceblue";
        String destFilePath = "output/AddParagraph_output.docx";
        String storage = null;
        paragraphsApi.addParagraph(name, nodePath, destFilePath, folder, storage, indexOfParagraph, password, text);
    }
    public static void deleteParagraph() throws ApiException {
        String fileName = "deleteParagraph.docx";
        String name = fileName;
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String password = null;
        String storage = null;
        String destFilePath = "output/DeleteParagraph_output.docx";
        paragraphsApi.deleteParagraph(name, nodePath, index, destFilePath, folder, storage, password);
    }
    public static void getParagraphChildObjects() throws ApiException {
        String fileName = "getParaChildObjects.docx";
        String name = fileName;
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo>  response = paragraphsApi.getParagraphChildObjects(name, nodePath, index, folder, storage,password);
    }
    public static void getParagraphformat() throws ApiException {
        String fileName = "getParagraphformat.docx";
        String name = fileName;
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        ParagraphFormat response = paragraphsApi.getParagraphFormat(name, nodePath, index, folder, storage,password);
    }
    public static void getParagraphs() throws ApiException {
        String fileName = "getParagraphs.docx";
        String name = fileName;
        String folder = "input";
        String storage = null;
        String password = null;
        String nodePath = null;
        List<ObjectInfo> response = paragraphsApi.getParagraphs(name, folder, storage, password, nodePath);
    }
    public static void updateParagraphFormat() throws ApiException {
        String fileName = "updateParagraphFormat.docx";
        String name = fileName;
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        ParagraphFormat format = new ParagraphFormat();
        format.setHorizontalAlignment(ParagraphFormat.HorizontalAlignmentEnum.DISTRIBUTE);
        format.setLeftOrInnerIndent(20f);
        format.setRightOrOutsideIndent(10f);
        format.setMirrorIndents(false);
        format.setFirstLineIndent(30f);
        format.setBackgroundColor( new Color(0, 200, 200));
        format.setBeforeSpacing(40f);
        format.setAfterSpacing(40f);
        format.setBeforeAutoSpacing(false);
        format.setBeforeAutoSpacing(false);
        format.setLineSpace(50f);
        format.setLineSpacingRule( ParagraphFormat.LineSpacingRuleEnum.EXACTLY);
        format.setWordWrap(true);
        Border topBorder = new Border();
        topBorder.setBorderType(Border.BorderTypeEnum.DOUBLE);
        Borders borders = new Borders();
        borders.setTopBorder(topBorder);
        format.setBorders(borders);
        String destFilePath = "output/UpdateParagraphFormat_output.docx";
        paragraphsApi.updateParagraphFormat(name, nodePath, index, format, destFilePath,folder, storage, password );
    }
    public static void updateParagraphText() throws ApiException {
        String fileName = "updateParagraphText.docx";
        String name = fileName;
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String text = "E-iceblue";
        String folder = "input";
        String password = null;
        String storage = null;
        String destFilePath = "output/UpdateParagraphText_output.docx";
        paragraphsApi.updateParagraphText(name, nodePath, index, text, destFilePath,folder, storage, password);
    }
 }
