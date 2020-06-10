import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.WatermarksApi;
import spire.cloud.word.sdk.client.model.*;
import java.io.File;

public class WatermarksApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static WatermarksApi watermarksApi = new WatermarksApi(wordConfiguration);
    
    public static void deleteWatermark() throws ApiException {
        String fileName = "deleteWatermark.docx";
        String folder = "input";
        String storage = null;
        String password =null;
        String destFilePath = "output/deleteWatermark_output.docx";
        watermarksApi.deleteWatermark(fileName, destFilePath, folder, storage, password);
    }
    public static void getTextWatermarkFormat() throws ApiException {
        String fileName = "getTextWatermarkFormat.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        TextWatermark response = watermarksApi.getTextWatermarkFormat(fileName, folder, storage, password);
    }
    public static void setImageWatermark() throws ApiException {
        String fileName = "setImageWatermark.docx";
        String imagePath = "images/Background.png";
        String folder = "input";
        String storage = null;
        Integer scaling = 120;
        Boolean washout = true;
        String password = null;
        String destFilePath = "output/setImageWatermark_output.docx";
        watermarksApi.setImageWatermark(fileName, imagePath, destFilePath,folder, storage, scaling, washout, password);
    }
    public static void setImageWatermarkInRequest() throws ApiException {
        String name = "watermark.docx";
        String inputFilePath = "D:/inputFile/Background.png";
        File inputImage = new File(inputFilePath);
        String folder = "input";
        String storage = null;
        Integer scaling = 120;
        Boolean washout = false;
        String password = null;
        String destFilePath = "output/setImageWatermarkInRequest_output.docx";
        watermarksApi.setImageWatermarkInRequest(name, inputImage, destFilePath, folder, storage, scaling, washout, password);
    }
    public static void setTextWatermark() throws ApiException {
        String name = "setTextWatermark.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        TextWatermark tempVar = new TextWatermark("E-iceblue");
        tempVar.setLayout(TextWatermark.LayoutEnum.HORIZONTAL);
        Color color = new Color(100, 100, 100);
        Font font = new Font("Cooper Black", 60f, color);
        tempVar.setFont(font);
        TextWatermark body = tempVar;
        String destFilePath = "output/setTextWatermark_output.docx";
        watermarksApi.setTextWatermark(name, body, destFilePath, folder, storage, password);
    }
}
