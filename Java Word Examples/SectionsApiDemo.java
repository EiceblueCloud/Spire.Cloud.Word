import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.SectionsApi;
import spire.cloud.word.sdk.client.model.*;
import java.util.List;

public class SectionsApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    
    public static void getPageSetup() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        SectionsApi api = new SectionsApi(wordConfiguration);
        String name ="getPageSetup.docx";
        Integer sectionIndex = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        PageSetup response = api.getPageSetup(name, sectionIndex, folder, storage, password);
    }
    public static void getSectionObjects() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        SectionsApi api = new SectionsApi(wordConfiguration);
        String name  ="getSectionObjects.docx";
        Integer sectionIndex = 0;
        String folder ="input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = api.getSectionObjects(name, sectionIndex, folder, storage, password);
    }
    public static void updatePageSetup() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        SectionsApi api = new SectionsApi(wordConfiguration);
        String name  ="updatePageSetup.docx";
        Integer sectionIndex = 0;
        PageSetup pageSetup = new PageSetup();
        pageSetup.orientation(PageSetup.OrientationEnum.LANDSCAPE);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/updatePageSetup_output.docx";
        api.updatePageSetup(name, sectionIndex, pageSetup, folder, storage, password, destFilePath);
    }
}
