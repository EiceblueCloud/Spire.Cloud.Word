import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Template.docx'
index = 3
table_path = 'Section/0/Body/0/Table/6'
extra = {'folder': "input", 'dest_file_path': 'output/DeleteTableRow.docx'}
result = api.delete_table_row(file_name, table_path, index, **extra)