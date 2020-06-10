import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.MergeApi;
import spire.cloud.word.sdk.client.model.MergingFile;

import java.util.*;

public class MergeApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static MergeApi mergeApi = new MergeApi(wordConfiguration);

    public static void mergeDocument() throws ApiException {
        String name = "mergeDocument1.docx";
        List<MergingFile> files = new ArrayList<MergingFile>();
        files.add(new MergingFile("input/mergeDocument2.docx",null,null));
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/mergeDocument_output.docx";
        mergeApi.mergeDocument(name, files, destFilePath, folder, storage, password);
    }
}
