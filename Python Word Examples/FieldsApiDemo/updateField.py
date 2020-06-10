import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = "UpdateField.docx"
extra = {'folder': 'input',
         'dest_file_path': 'Fields/UpdateField.docx'}
result = api.update_field(file_name, **extra)