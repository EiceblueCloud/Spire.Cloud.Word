import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.ShapesApi;
import spire.cloud.word.sdk.client.model.*;

public class ShapesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void addShape() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ShapesApi shapesApi = new ShapesApi(wordConfiguration);
        String name = "addShape.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        int indexInParagraph = 1;
        String folder = "input";
        String storage = null;
        String password = null;
        ShapeFormat shapeProperties = new ShapeFormat();
        shapeProperties.width(10.0f);
        shapeProperties.height(10.0f);
        shapeProperties.shapeType(ShapeFormat.ShapeTypeEnum.ARC);
        String destFilePath = "output/addShape_output.docx";
        shapesApi.addShape(name, paragraphPath, shapeProperties, folder, storage, indexInParagraph, password, destFilePath);
    }

    public static void deleteShape() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ShapesApi shapesApi = new ShapesApi(wordConfiguration);
        String name = "deleteShape.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/deleteShape_output.docx";
        shapesApi.deleteShape(name, paragraphPath, index, folder, storage, password, destFilePath);
    }

    public static void getShapeProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ShapesApi shapesApi = new ShapesApi(wordConfiguration);
        String name = "getShapeProperties.docx";
        String paragraphPath = "sections/0/paragraphs/0"; ;
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        ShapeFormat response = shapesApi.getShapeProperties(name, paragraphPath, index, folder, storage, password);
    }

    public static void updateShapeProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        ShapesApi shapesApi = new ShapesApi(wordConfiguration);
        String name = "updateShapeProperties.docx";
        String paragraphPath = "sections/0/paragraphs/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;

        String password = null;
        ShapeFormat shapeProperties = new ShapeFormat();
        shapeProperties.width(20.0f);
        shapeProperties.height(20.0f);
        shapeProperties.shapeType(ShapeFormat.ShapeTypeEnum.ARC);
        String destFilePath = "output/updateShapeProperties_output.docx";
        shapesApi.updateShapeProperties(name, paragraphPath, index, shapeProperties, folder, storage, password, destFilePath);
    }
}
