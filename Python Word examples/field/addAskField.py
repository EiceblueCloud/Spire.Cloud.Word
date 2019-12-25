import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = "Template.docx"
paragraph_path = "sections/0/paragraphs/0"
filed_code = "ASK  x \"Male = 1  Female = 2 Else = 3\" \\d \"1\" \\o"
extra_add = {
    'folder': 'input',
    'index_in_paragraph': 0,
    'dest_file_path': 'Test/Field/AddField_Ask.docx'}
api.add_field(file_name, paragraph_path, filed_code, **extra_add)
# Updates all fields in document.
extra_update = {
    'folder': 'Test/Field',
    'dest_file_path': 'Test/Field/AddField_Ask.docx'}
api.update_field("AddField_Ask.docx", **extra_update)
