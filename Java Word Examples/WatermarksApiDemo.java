import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.WatermarksApi;
import spire.cloud.word.sdk.client.model.*;
import java.io.File;

public class WatermarksApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    
    public static void deleteWatermark()throws ApiException  {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        WatermarksApi api = new WatermarksApi(wordConfiguration);
        String name  ="deleteWatermark.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/deleteWatermark_output.docx";
        api.deleteWatermark(name, folder, storage, password, destFilePath);
    }
    public static void getTextWatermarkProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        WatermarksApi api = new WatermarksApi(wordConfiguration);
        String name  ="getTextWatermarkProperties.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        TextWatermark response = api.getTextWatermarkProperties(name, folder, storage, password);
    }
    public static void setImageWatermark() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        WatermarksApi api = new WatermarksApi(wordConfiguration);
        String name="setImageWatermark.docx";
        String imagePath = "input/Background.png";
        String folder = "input";
        String storage = null;
        Integer scaling = 100;
        Boolean washout = true;
        String password = null;
        String destFilePath ="output/setImageWatermark_output.docx";
        api.setImageWatermark(name, imagePath, folder, storage, scaling, washout, password, destFilePath);
    }
    public static void setImageWatermarkOnLine() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        WatermarksApi api = new WatermarksApi(wordConfiguration);
        String name ="setImageWatermarkOnLine.docx";
        File inputImage = new File("inputFile/Background.png");
        String folder = "input";
        String storage = null;
        Integer scaling = 60;
        Boolean washout = true;
        String password = null;
        String destFilePath ="output/setImageWatermarkOnLine_output.docx";
        api.setImageWatermarkOnLine(name, inputImage, folder, storage, scaling, washout, password, destFilePath);
    }
    public static void setTextWatermark() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        WatermarksApi api = new WatermarksApi(wordConfiguration);
        String name ="setTextWatermark.docx";
        TextWatermark body = new TextWatermark();
        body.text("Test");
        Font font=new Font();
        font.fontSize(60.0f);
        font.fontName("宋体");
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/setTextWatermark_output.docx";
        api.setTextWatermark(name, body, folder, storage, password, destFilePath);
    }
}
