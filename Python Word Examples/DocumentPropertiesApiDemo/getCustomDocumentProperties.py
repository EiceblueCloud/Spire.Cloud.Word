import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.document_properties_api.DocumentPropertiesApi(configuration)

file_name = 'CustomDocumentProperties.docx'
folder = 'input'
custom_properties = api.get_custom_document_properties(file_name, folder=folder)