import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Template.docx'
table_row_path = 'Section/0/Body/0/Table/6/TableRow/0'
index = 2
extra = {'folder': "input", 'dest_file_path': 'output/DeleteTableCell_3.docx'}
result = api.delete_table_cell(file_name, table_row_path, index, **extra)