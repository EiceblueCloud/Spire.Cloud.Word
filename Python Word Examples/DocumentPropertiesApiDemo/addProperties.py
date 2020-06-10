import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.document_properties_api.DocumentPropertiesApi(configuration)

file_name = 'AddDocumentProperties.docx'  # Supported formats:doc, docx, docm, dot, dotx, dotm, rtf
custom_properties_list = []
custom_properties_list.append(CustomDocumentProperty('Keywords', 'Set document properties.'))
custom_properties_list.append(CustomDocumentProperty('Author', 'eiceblue'))
custom_properties_list.append(CustomDocumentProperty('Company', '冰蓝'))
custom_properties_list.append(CustomDocumentProperty('LastSavedBy', '123456@iCloud.com'))
custom_properties_list.append(CustomDocumentProperty('SharedDoc', 'true'))
custom_properties_list.append(CustomDocumentProperty('Date', '2019/10/30'))
extra = {'folder': 'input',
         'dest_file_path': 'output/AddCustomDocumentProperties.docx'}
api.add_custom_document_properties(file_name, custom_properties_list, **extra)
