import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ShapesApi;
import spire.cloud.word.sdk.client.model.*;
import java.util.List;

public class ShapesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static ShapesApi shapesApi = new ShapesApi(wordConfiguration);

    public static void addShape() throws ApiException {
        String name = "addShape.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        int indexInParagraph = 1;
        String folder = "input";
        String storage = null;
        String password = null;
        ShapeFormat shapeFormat = new ShapeFormat(40f, 40f, ShapeFormat.ShapeTypeEnum.RECTANGLE);
        shapeFormat.setHorizontalOrigin(ShapeFormat.HorizontalOriginEnum.PAGE);
        shapeFormat.setVerticalOrigin(ShapeFormat.VerticalOriginEnum.PARAGRAPH);
        shapeFormat.setVerticalPosition(50f);
        shapeFormat.setHorizontalPosition(150f);
        Color color = new Color(0, 206, 209);
        shapeFormat.setFillColor(color);
        shapeFormat.setRotation(45f);
        shapeFormat.setStrokeWeight(2f);
        Color color_2 = new Color(173, 255, 47);
        shapeFormat.setStrokeColor(color_2);
        shapeFormat.setTextWrappingType(ShapeFormat.TextWrappingTypeEnum.BOTH);
        shapeFormat.setTextWrappingStyle(ShapeFormat.TextWrappingStyleEnum.INFRONTOFTEXT);
        shapeFormat.setZOrder(1);
        ShapeFormat shapeProperties = shapeFormat;
        String destFilePath = "output/addShape_output.docx";
        shapesApi.addShape(name, paragraphPath, shapeFormat, destFilePath,folder, storage, indexInParagraph, password);
    }

    public static void deleteShape() throws ApiException {
        String name = "deleteShape.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/deleteShape_output.docx";
        shapesApi.deleteShape(name, paragraphPath, index, destFilePath, folder, storage, password);
    }
    public static void getShapeFormat() throws ApiException {
        String name = "template.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0"; ;
        Integer index = 3;
        String folder = "input";
        String storage = null;
        String password = null;
        ShapeFormat response = shapesApi.getShapeFormat(name, paragraphPath, index, folder, storage, password);
    }
    public static void getShapes() throws ApiException {
        String name = "getShapes.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        String paragraphPath = null;
        List<ObjectInfo> response = shapesApi.getShapes(name, folder, storage, password, paragraphPath);
    }
    public static void updateShapeFormat() throws ApiException {
        String name = "updateShapeFormat.docx";
        String paragraphPath = "Section/0/Body/0/Paragraph/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        ShapeFormat shapeFormat = new ShapeFormat(50f, 50f, ShapeFormat.ShapeTypeEnum.OCTAGON);
        shapeFormat.setHorizontalOrigin(ShapeFormat.HorizontalOriginEnum.LEFTMARGINAREA);
        shapeFormat.setVerticalOrigin(ShapeFormat.VerticalOriginEnum.PARAGRAPH);
        shapeFormat.setVerticalPosition(80f);
        shapeFormat.setHorizontalPosition(80f);
        Color color = new Color(100, 100, 100);
        shapeFormat.setFillColor(color);
        shapeFormat.setRotation(0f);
        shapeFormat.setStrokeWeight(2f);
        Color color_2 = new Color(0, 206, 209);
        shapeFormat.setStrokeColor(color_2);
        shapeFormat.setTextWrappingType(ShapeFormat.TextWrappingTypeEnum.BOTH);
        shapeFormat.setTextWrappingStyle(ShapeFormat.TextWrappingStyleEnum.INFRONTOFTEXT);
        shapeFormat.setZOrder(1);
        ShapeFormat shapeProperties = shapeFormat;
        String destFilePath = "output/updateShapeFormat_output.docx";
        shapesApi.updateShapeFormat(name, paragraphPath, index, shapeFormat, destFilePath, folder, storage, password);
    }
}
