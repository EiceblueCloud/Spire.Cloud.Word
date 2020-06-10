import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Table.docx'
table_row_path = 'Section/0/Body/0/Table/0/TableRow/0'
index = 0
result = api.get_table_cell_format(file_name, table_row_path, index, folder="input")