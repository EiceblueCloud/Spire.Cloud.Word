import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.TextRangesApi;
import spire.cloud.word.sdk.client.model.*;
import java.util.List;

public class TextRangesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static TextRangesApi textRangesApi = new TextRangesApi(wordConfiguration);

    public static void addTextRange() throws ApiException {
        String name = "Template.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer  indexInParagraph = 0;
        String text = "E-iceblue";
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/AddTextRange_output.docx";
        textRangesApi.addTextRange(name, paragraphPath, text, destFilePath, folder, storage, indexInParagraph, password);
    }
    public static void deleteTextRange() throws ApiException {
        String name = "deleteTextRange.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer  index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/DeleteTextRange_output.docx";
        textRangesApi.deleteTextRange(name, paragraphPath, index, destFilePath,folder, storage, password);
    }
    public static void getTextRangeFormat() throws ApiException {
        String name = "getTextRangeFormat.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer  index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TextRangeFormat response = textRangesApi.getTextRangeFormat(name, paragraphPath, index, folder, storage, password);
    }
    public static void getTextRangeText() throws ApiException {
        String name = "Template.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer  index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String response = textRangesApi.getTextRangeText(name, paragraphPath, index, folder, storage, password);
    }
    public static void getTextRanges() throws ApiException {
        String name = "Template.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = textRangesApi.getTextRanges(name, paragraphPath, folder, storage, password);
    }
    public static void updateTextRangeFormat() throws ApiException {
        String name = "Template.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer  index = 0;
        TextRangeFormat format = new TextRangeFormat();
        Color color = new Color(0, 255, 255);
        Font font = new Font("ו", 30f, color);
        format.setFont(font);
        TextRangeFormat textRange = format;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/UpdateTextRangeFormat_output.docx";
        textRangesApi.updateTextRangeFormat(name, paragraphPath, index, textRange, destFilePath, folder, storage, password);
    }
    public static void updateTextRangeText() throws ApiException {
        String name = "Template.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0"; ;
        Integer  index = 0;
        String text = "E-iceblue test textRange";
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/UpdateTextRangeText_output.docx";
        String response = textRangesApi.updateTextRangeText(name, paragraphPath, index, text, destFilePath, folder, storage, password);
    }
}
