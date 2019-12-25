import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.document_properties_api.DocumentPropertiesApi(configuration)

#Support file format: docx, doc, docm, dot, dotx, dotm, rtf
file_name = "DocumentProperties.docx"
custom_property_name_1 = 'E-iceblue'
extra = {'folder': 'input',
         'dest_file_path': '/output/DeleteCustomDocumentProperties.docx'}
api.delete_custom_document_properties("DocumentProperties.docx", custom_property_name_1, **extra)




