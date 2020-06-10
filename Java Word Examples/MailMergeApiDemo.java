import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.MailMergeApi;
import spire.cloud.word.sdk.client.model.MailMergeData;
import java.util.*;

public class MailMergeApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static MailMergeApi mailMergeApi = new MailMergeApi(wordConfiguration);

    public static void mailMerge() throws ApiException {
        String name = "mailMerge.doc";
        List<MailMergeData> data = new ArrayList<MailMergeData>();
        data.add(new MailMergeData("Contact Name", "E-iceblue"));
        data.add(new MailMergeData("Fax", "TestFax"));
        data.add(new MailMergeData("Date", "2020-5-10"));
        String folder = "input";
        String storage = null;
        String password = null;
        String destFileName = "output/mailMerge_output.docx";
        mailMergeApi.mailMerge(name, destFileName, data, folder, storage, password);
    }

}
