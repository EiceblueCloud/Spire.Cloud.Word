import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.SectionsApi;
import spire.cloud.word.sdk.client.model.*;
import java.util.List;

public class SectionsApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static SectionsApi sectionsApi = new SectionsApi(wordConfiguration);

    public static void addSection() throws ApiException {
        String name = "template.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        Integer  sectionIndex = null;
        String destFilePath = "output/addSection_output.docx";
        sectionsApi.addSection(name, destFilePath, folder, storage, password, sectionIndex);
    }
    public static void getPageSetup() throws ApiException {
        String name = "getPageSetup.docx";
        Integer  sectionIndex = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        PageSetup response = sectionsApi.getPageSetup(name, sectionIndex, folder, storage, password);
    }
    public static void getSectionChildObjects() throws ApiException {
        String name = "getSectionChildObjects.docx"; ;
        Integer  sectionIndex = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = sectionsApi.getSectionChildObjects(name, sectionIndex, folder, storage, password);
    }
    public static void getSections() throws ApiException {
        String name = "template.docx"; ;
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo>  response = sectionsApi.getSections(name, folder, storage, password);
    }
    public static void updatePageSetup() throws ApiException {
        String name = "updatePageSetup.docx"; ;
        Integer  sectionIndex = 0;
        String storage = null;
        Margin marging = new Margin();
        marging.setTop(20f);
        marging.setBottom(20f);
        marging.setLeft(20f);
        marging.setRight(20f);
        LineNumber linenumber = new LineNumber(1, 2);
        linenumber.setRestartMode(LineNumber.RestartModeEnum.CONTINUOUS);
        linenumber.setDistanceFromText(20f);
        PageSetup pageSetup = new PageSetup();
        pageSetup.setPageWidth(400f);
        pageSetup.setPageHeight(500f);
        pageSetup.setPageMargin(marging);
        pageSetup.setOrientation(PageSetup.OrientationEnum.LANDSCAPE);
        pageSetup.setLinenumber(linenumber);
        String folder = "input";
        String password = null;
        String destFilePath = "output/updatePageSetup_output.docx";
        sectionsApi.updatePageSetup(name, sectionIndex, pageSetup, destFilePath,folder, storage, password);
    }
}
