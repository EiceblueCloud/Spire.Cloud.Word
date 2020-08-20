(function (){
    var appId = "your id";
    var appKey = "your key"; 
    var baseUrl = "https://api.e-iceblue.cn";

    var Spirecloudword= require('../../src/index');
    var apiClient = new Spirecloudword.ApiClient(appId, appKey,baseUrl);
    var instance = new Spirecloudword.ImagesApi(apiClient);

    var name = "Template.docx";
    var imagePath = "input/image.png";
    var paragraphPath = "Section/0/Body/0/Paragraph/0";
    var indexInParagraph = 0;
    var destFilePath = 'output/AddImage.docx';
    var opt = { folder: 'input', indexInParagraph: indexInParagraph };
    instance.addImage(name, imagePath, paragraphPath, destFilePath, opt,
        function (error, data, response) {
            if (error) throw error;
        });
})();