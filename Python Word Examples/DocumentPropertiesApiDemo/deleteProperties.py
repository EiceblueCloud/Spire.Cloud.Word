import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.document_properties_api.DocumentPropertiesApi(configuration)

file_name = 'DeleteCustomDocumentProperties.docx'
custom_property_name_1 = 'Date'
extra = {'folder': 'input',
         'dest_file_path': 'output/DeleteCustomDocumentProperties.docx'}
api.delete_custom_document_properties(file_name, custom_property_name_1, **extra)