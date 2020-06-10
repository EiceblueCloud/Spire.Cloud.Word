import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.*;
import spire.cloud.word.sdk.client.model.*;

import java.io.File;

public class BackgroundApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);

    public static void deleteBackground() throws ApiException {
        String name = "deleteBackground.docx";
        String password = null;
        String folder = "input";
        String destFilePath = "output/deleteBackground_output.docx";
        String storage = null;
        backgroundApi.deleteBackground(name, destFilePath, password, folder, storage);
    }

    public static void getBackgroundColor() throws ApiException {
        String name = "getBackgroundColor.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        Color response =  backgroundApi.getBackgroundColor(name, password, folder, storage);
    }

    public static void setBackgroundColor() throws ApiException {
        String name = "setBackgroundColor.docx";
        Color color = new Color(127, 255, 170);
        String password = null;
        String folder = "input";
        String destFilePath = "output/setBackgroundColor_output.docx";
        String storage = null;
        backgroundApi.setBackgroundColor(name, color, destFilePath, folder, storage, password);
    }

    public static void setBackgroundImage() throws ApiException {
        String name = "setBackgroundImage.docx";
        String imagePath = "input/Background.png";
        String password = null;
        String folder = "input";
        String destFilePath = "output/setBackgroundImage_output.docx";
        String storage = null;
        backgroundApi.setBackgroundImage(name, imagePath, destFilePath, folder, storage, password);
    }

    public static void setBackgroundImageInRequest() throws ApiException {
        String name = "setBackgroundImageWithImgFile.docx";
        File inputImage = new File("inputFile/Background.png");
        String password = null;
        String folder = "input";
        String destFilePath = "output/setBackgroundImageInRequest_output.docx";
        String storage = null;
        backgroundApi.setBackgroundImageInRequest(name, inputImage, destFilePath, folder, storage, password);
    }
}
