import spirecloudword
from spirecloudword import CustomDocumentProperty
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.document_properties_api.DocumentPropertiesApi(configuration)

#Support file format: docx, doc, docm, dot, dotx, dotm, rtf
file_name = "DocumentProperties.docx"
result = api.get_custom_document_properties(file_name, folder="input")





