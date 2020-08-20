(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.MailMergeApi(apiClient);
    
    var name = "MailMergeFormField.docx";
    var destFilePath = 'output/MailMerge/MailMerge.docx';
    var data = [
        new Spirecloudword.MailMergeData("Contact Name", "John Smith"),
        new Spirecloudword.MailMergeData("Fax", "+1 (69) 123456"),
        new Spirecloudword.MailMergeData("Date", "2019-10-16"),
        new Spirecloudword.MailMergeData("Urgent", "Yes"),
        new Spirecloudword.MailMergeData("Share", "No"),
        new Spirecloudword.MailMergeData("Submit", "Yes"),
        new Spirecloudword.MailMergeData("Body", "It's very urgent. Please deal with it ASAP.")
    ];
    var opt = {folder: 'mailmerge'};
    instance.mailMerge(name, destFilePath, data, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();