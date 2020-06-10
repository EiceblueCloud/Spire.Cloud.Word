import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ConvertApi;
import spire.cloud.word.sdk.client.model.PrivateFont;

import java.io.File;
import java.util.*;

public class ConvertApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static ConvertApi convertApi = new ConvertApi(wordConfiguration);

    public static void convert() throws ApiException {
        String name = "convert.docx";
        String format = "xps";//postScript, pcl, dot, dotx, dotm, docm, odt, wordxml, wordml, pdf, doc, docx, rtf, epub, xps, html
        String password = null;
        String folder = "input";
        String storage = null;
        String destFilePath = "output/convert_output.xps";
        convertApi.convert(name, format, destFilePath, password, folder, storage);
    }

    public static void convertInRequest() throws ApiException {
        String inputFilePath = "D:/inputFile/convert.docx";
        String format = "postScript";//postScript, pcl, dot, dotx, dotm, docm, odt, wordxml, wordml, pdf, doc, docx, rtf, epub, xps, html
        String password = null;
        File inputFile = new File(inputFilePath);
        convertApi.convertInRequest(inputFile, format, password);
    }

    public static void convertToBitmap() throws ApiException {
        String name = "convertToBitmap.docx";
        String imageFormat = "jpeg";//jpeg, bmp, png
        String password = null;
        String folder = "input";
        String storage = null;
        Integer startPage = null;
        Integer pageCount = null;
        String destFolder = "output/ConvertToBitmap_jpeg/";
        convertApi.convertToBitmap(name, imageFormat, destFolder, password, folder, storage, startPage, pageCount);
    }

    public static void convertToBitmapInRequest() throws ApiException {
        File inputFile = new File("D:/inputFile/convertToBitmapInRequest.docx");
        String imageFormat = "jpeg";//jpeg, bmp, png
        String password = null;
        Integer startPage = null;
        Integer pageCount = null;
        File response = convertApi.convertToBitmapInRequest(inputFile, imageFormat, password, startPage, pageCount);
    }

    public static void convertToHtml() throws ApiException {
        String name = "convertToHtml.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        String destFolder = "output/convertToHtml";
        convertApi.convertToHtml(name, destFolder, password, folder, storage);
    }

    public static void convertToHtmlInRequest() throws ApiException {
        File inputFile = new File("D:/inputFile/convertInRequest.docx");
        String password = null;
        File reponse = convertApi.convertToHtmlInRequest(inputFile, password);
    }

    public static void convertToPdf() throws ApiException {
        String name = "convertToPdf.docx";
        String password = null;
        String folder = "input";
        String storage = null;
        String destFilePath = "output/convertToPdf_out.pdf";
        List<PrivateFont> privateFonts = new ArrayList<PrivateFont>();
        privateFonts.add(new PrivateFont("黑体", "input/simhei.ttf"));
        privateFonts.add(new PrivateFont("consola", "input/consola.ttf"));
        convertApi.convertToPdf(name, destFilePath, password, folder, storage, privateFonts);
    }

    public static void convertToVectorgraph() throws ApiException {
        String name = "convertToVectorgraph.docx";
        String imageType = "wmf";//wmf, svg
        String password = null;
        String folder = "input";
        String storage = null;
        Integer startPage = null;
        Integer pageCount = null;
        String destFolder = "output/vectorgraph/";
        convertApi.convertToVectorgraph(name, imageType, destFolder, password, folder, storage, startPage, pageCount);
    }

    public static void convertToVectorgraphInRequest() throws ApiException {
        File inputFile = new File("D:/inputFile/convertToVectorgraphInRequest.docx");
        String imageType = "wmf";//wmf, svg
        String password = null;
        Integer startPage = null;
        Integer pageCount = null;
        convertApi.convertToVectorgraphInRequest(inputFile, imageType, password, startPage, pageCount);
    }
}
