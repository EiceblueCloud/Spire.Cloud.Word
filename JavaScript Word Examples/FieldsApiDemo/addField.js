(function (){
    var appId = "your id";
    var appKey = "your key";
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword = require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.FieldsApi(apiClient);
    
    var fileName = "AddField.docx";
    var fieldCode1 = 'DATE';
    var paragraph_path = "Section/0/Body/0/Paragraph/0";
    var destFilePath_Temp = "output/Fields/AddField1.docx";
    var opts = { 'folder': 'input', 'indexInParagraph': 0 };
    instance.addField(fileName, paragraph_path, fieldCode1, destFilePath_Temp, opts, 
    function (error, data, response) {
         if (error) throw error;
    });

     var fieldCode2 = 'IF 1 > 2 True False';
     destFilePath_Temp = "output/Fields/AddField2.docx";
     instance.addField(fileName, paragraph_path, fieldCode2, destFilePath_Temp, opts, 
     function (error, data, response) {
          if (error) throw error;
     });

     var inputimg = "logo.png"
     var fieldCode3 = "INCLUDEPICTURE \"" + inputimg + "\"" + " \\d \\*MERGEFORMAT";
     destFilePath_Temp = "output/Fields/AddField3.docx";
     instance.addField(fileName, paragraph_path, fieldCode3, destFilePath_Temp, opts, 
     function (error, data, response) {
          if (error) throw error;
     });

     var fieldCode4 = "ASK  x " + "\"" + "Male = 1  Female = 2 Else = 3" + "\"" + " \\d \"1\" \\o";
     destFilePath_Temp = "output/Fields/AddField4.docx";
     instance.addField(fileName, paragraph_path, fieldCode4, destFilePath_Temp, opts, 
     function (error, data, response) {
          if (error) throw error;
     });
 
     var fieldCode5 = "DisplayBarcode\"490123456789\" EAN13 \\t \\h 1200 \\s 1000 \\p STD \\x \\r 0 \\b 87CEEB";
     destFilePath_Temp = "output/Fields/AddField5.docx";
     instance.addField(fileName, paragraph_path, fieldCode5, destFilePath_Temp, opts, 
     function (error, data, response) {
          if (error) throw error;
     });

     var fieldCode6 = "EQ 3/f(3,4)";
     destFilePath_Temp = "output/Fields/AddField6.docx";
     instance.addField(fileName, paragraph_path, fieldCode6, destFilePath_Temp, opts, 
     function (error, data, response) {
          if (error) throw error;
     });

     var fieldCode7 = "=6*7 \\# \"#,##0.00";
     destFilePath_Temp = "output/Fields/AddField7.docx";
     instance.addField(fileName, paragraph_path, fieldCode7, destFilePath_Temp, opts, 
     function (error, data, response) {
          if (error) throw error;
     });

     var fieldCode8 =  "PAGE NumPage";
     destFilePath_Temp = "output/Fields/AddField8.docx";
     instance.addField(fileName, paragraph_path, fieldCode8, destFilePath_Temp, opts, 
     function (error, data, response) {
          if (error) throw error;
     });
})();