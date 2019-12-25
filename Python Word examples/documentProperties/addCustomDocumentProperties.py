import spirecloudword
from spirecloudword import CustomDocumentProperty
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.document_properties_api.DocumentPropertiesApi(configuration)

#Support file format: docx, doc, docm, dot, dotx, dotm, rtf
file_name = "Template.docx"
custom_properties_list = [CustomDocumentProperty("Keywords", "Set document properties."),
                          CustomDocumentProperty("Author", "eiceblue"), CustomDocumentProperty("Company", "e-iceblue"),
                          CustomDocumentProperty("LastSavedBy", "123456@iCloud.com"),
                          CustomDocumentProperty("SharedDoc", "true"), CustomDocumentProperty("Date", "2019/10/30")]
extra = {'folder': "input", 'dest_file_path': "/output/AddCustomDocumentProperties.docx"}

result = api.add_custom_document_properties(file_name, custom_properties_list, **extra)



