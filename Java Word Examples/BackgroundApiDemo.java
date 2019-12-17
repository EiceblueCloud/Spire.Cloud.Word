import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.BackgroundApi;
import spire.cloud.word.sdk.client.model.Color;

import java.io.File;

public class BackgroundApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void deleteBackground() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
        String name = "deleteBackground.docx";
        String password = null;
        String folder = "input";
        String destFilePath = "output/deleteBackground_output.docx";
        String storage = null;
        backgroundApi.deleteBackground(name, password, folder, storage, destFilePath);
    }

    public static void getBackgroudColor() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
        String name = "getBackgroundColor.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        Color response =  backgroundApi.getBackgroudColor(name, password, folder, storage);
    }

    public static void setBackgroudColor() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
        String name = "setBackgroundColor.docx";
        Color color = new Color();
        color.red(100);
        color.green(100);
        color.blue(100);
        String password = null;
        String folder = "input";
        String destFilePath = "output/setBackgroundColor_output.docx";
        String storage = null;
        backgroundApi.setBackgroudColor(name, color, folder, storage, password, destFilePath);
    }

    public static void setBackgroudImage() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
        String name = "setBackgroundImage.docx";
        String imagePath = "input/Background.png";
        String password = null;
        String folder = "input";
        String destFilePath = "output/setBackgroundImage_output.docx";
        String storage = null;
        backgroundApi.setBackgroudImage(name, imagePath, folder, storage, password, destFilePath);
    }

    public static void setBackgroudImageWithImgFile() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        BackgroundApi backgroundApi = new BackgroundApi(wordConfiguration);
        String name = "setBackgroundImageWithImgFile.docx";
        File inputImage = new File("inputFile/Background.png");
        String password = null;
        String folder = "input";
        String destFilePath = "output/setBackgroundImageWithImgFile_output.docx";
        String storage = null;
        backgroundApi.setBackgroundImageWithImgFile(name, inputImage, folder, storage, password, destFilePath);
    }
}
