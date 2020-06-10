import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = 'Fileds.docx'
paragraph_path = "Section/0/Body/0/Paragraph/0"
index = 2
dest_file_path = 'output/DeleteField.docx'
extra = {'folder': 'input'}
api.delete_field(file_name, paragraph_path, index, dest_file_path, **extra)