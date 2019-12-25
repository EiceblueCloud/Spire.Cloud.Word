import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = "Fields.docx"
paragraph_path = "sections/0/paragraphs/0"
index = 0
extra = {'folder': 'input', 'dest_file_path': 'output/DeleteField.docx'}
api.delete_field(file_name, paragraph_path, index, **extra)







