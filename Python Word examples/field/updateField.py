import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = "Fields.docx"
extra = {'folder': 'input', 'dest_file_path': 'output/UpdateField.docx'}
result = api.update_field(file_name, **extra)







