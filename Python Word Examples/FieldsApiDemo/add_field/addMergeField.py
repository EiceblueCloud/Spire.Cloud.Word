import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.fields_api.FieldsApi(configuration)

file_name = "Template.docx"
paragraph_path = "sections/0/paragraphs/0"
field_name = 'FiledTest'
extra = {'folder': 'input',
         'index_in_paragraph': 0,
         'dest_file_path': 'output/AddMergeField.docx'}
api.add_merge_field(file_name, paragraph_path, field_name, **extra)







