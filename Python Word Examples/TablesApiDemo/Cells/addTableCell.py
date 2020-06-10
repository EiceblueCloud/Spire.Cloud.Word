import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Template.docx'
table_row_path = 'Section/0/Body/0/Table/6/TableRow/0'
extra = {'index_of_table_cell': 2, 'folder': "input", 'dest_file_path': 'output/AddTableCell_3.docx'}
result = api.add_table_cell(file_name, table_row_path, **extra)