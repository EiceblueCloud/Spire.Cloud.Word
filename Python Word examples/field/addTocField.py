import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = "Template.docx"
paragraph_path = "sections/0/paragraphs/0"
filed_code = "TOC \\o \"1-3\" \\h \\z \\u"
extra_add = {
    'folder': 'input',
    'index_in_paragraph': 0,
    'dest_file_path': 'output/AddField_TOC.docx'}
api.add_field(file_name, paragraph_path, filed_code, **extra_add)






