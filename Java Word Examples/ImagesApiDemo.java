import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ImagesApi;
import spire.cloud.word.sdk.client.model.ImageFormat;

import java.io.File;

public class ImagesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static ImagesApi imagesApi = new ImagesApi(wordConfiguration);

    public static void addImage() throws ApiException {
        String name = "addImage.docx";
        String imagePath = "input/image.png";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        String folder = "input";
        String storage = null;
        String password = null;
        Integer indexInParagraph = 0;
        String destFilePath = "output/addImage_out.docx";
        imagesApi.addImage(name, imagePath, paragraphPath, destFilePath, folder, storage, password, indexInParagraph);
    }

    public static void addImageInRequest() throws ApiException {
        String name = "addImage.docx";
        File inputImage = new File("../../inputFile/image.png");
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        String folder = "input";
        String storage = null;
        String password = null;
        Integer indexInParagraph = 0;
        String destFilePath = "output/addImage_out.docx";
        imagesApi.addImageInRequest(name, inputImage, paragraphPath, destFilePath, folder, storage, password, indexInParagraph);
    }

    public static void deleteImage() throws ApiException {
        String name = "deleteImage.docx";
        ;
        String paragraphPath = "Section/0/Body/0/Paragraph/1";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/addImage_out.docx";
        imagesApi.deleteImage(name, paragraphPath, index, destFilePath, folder, storage, password);
    }

    public static void getImageFormat() throws ApiException {
        String name = "getImageFormat.docx";
        ;
        String paragraphPath = "Section/0/Body/0/Paragraph/1";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        imagesApi.getImageFormat(name, paragraphPath, index, password, folder, storage);
    }

    public static void getImages() throws ApiException {
        String name = "getImages.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/1";
        String folder = "input";
        String storage = null;
        String password = null;
        imagesApi.getImages(name, password, folder, storage, paragraphPath);
    }

    public static void updateImageFormat() throws ApiException {
        String name = "updateImageFormat.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/1";
        Integer index = 0;
        ImageFormat format = new ImageFormat();
        format.setWidth(400);
        format.setHeight(400);
        format.setRotation(20);
        format.setVerticalPosition(50);
        format.setHorizontalPosition(50);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/updateImageFormat_out.docx";
        imagesApi.updateImageFormat(name, paragraphPath, index, destFilePath, format, password, folder, storage);
    }
}
