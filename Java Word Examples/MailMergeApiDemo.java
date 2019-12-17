import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.MailMergeApi;
import spire.cloud.word.sdk.client.model.MailMergeData;
import java.util.ArrayList;
import java.util.List;

public class MailMergeApiDemo {
    static String appId = "your id";
    static String appKey = "your key";

    public static void mailMerge() throws ApiException{
        Configuration wordConfiguration = new Configuration(appId, appKey);
        MailMergeApi mailMergeApi = new MailMergeApi(wordConfiguration);
        String name = "mailMerge.doc";
        List<MailMergeData> data = new ArrayList<>();
        MailMergeData mailMergeData1=new MailMergeData();
        mailMergeData1.name("Contact Name");
        mailMergeData1.value("testValue1");
        MailMergeData mailMergeData2=new MailMergeData();
        mailMergeData2.name("Fax");
        mailMergeData2.value("testValue2");
        MailMergeData mailMergeData3=new MailMergeData();
        mailMergeData3.name("Date");
        mailMergeData3.value("testValue3");
        data.add(mailMergeData1);
        data.add(mailMergeData2);
        data.add(mailMergeData3);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFileName = "output/mailMerge_output.docx";
        mailMergeApi.mailMerge(name, data, folder, storage, password, destFileName);
    }
}
