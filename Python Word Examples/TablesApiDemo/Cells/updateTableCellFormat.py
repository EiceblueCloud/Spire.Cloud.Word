import spirecloudword
from spirecloudword import TableCellFormat, Color
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Template.docx'
index = 2
table_row_path = 'Section/0/Body/0/Table/6/TableRow/0'
cell_format = TableCellFormat()
cell_format._background_color = Color(100, 100, 100)
cell_format._width = 50
extra = {'folder': "input", 'dest_file_path': 'output/UpdateTableCellFormat.docx'}
result = api.update_table_cell_format(file_name, table_row_path, index, cell_format, **extra)