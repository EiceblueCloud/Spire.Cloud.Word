import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.MergeApi;
import spire.cloud.word.sdk.client.model.MergingFile;
import java.util.ArrayList;
import java.util.List;

public class MergeApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void mergeDocument() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        MergeApi mergeApi = new MergeApi(wordConfiguration);
        String name = "mergeDocument1.docx";
        List<MergingFile> files = new ArrayList<>();
        MergingFile mergingFile1=new MergingFile();
        mergingFile1.fileName("mergeDocument2.docx");
        mergingFile1.fileFolder("input");
        files.add(mergingFile1);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/mergeDocument_output.docx";
        mergeApi.mergeDocument(name, files, folder, storage, password, destFilePath);
    }
}
