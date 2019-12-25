import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = "Template.docx"
paragraph_path_2 = "sections/0/paragraphs/1"
filed_code_2 = "IF 1 > 2 True False"
extra_add2 = {
    'folder': 'input',
    'index_in_paragraph': 0,
    'dest_file_path': 'output/AddIfField.docx'}
result = api.add_field(file_name, paragraph_path_2, filed_code_2, **extra_add2)





