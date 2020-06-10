import spirecloudword
from spirecloudword import TableRowFormat
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Template.docx'
index = 3
table_path = 'Section/0/Body/0/Table/6'
row_format = TableRowFormat()
row_format._height = 50
row_format._height_type = 'Auto'
row_format._break_across_pages = False
row_format._header = True
extra = {'folder': "input", 'dest_file_path': 'Tables/UpdateTableRowFormat.docx'}
result = api.update_table_row_format(file_name, table_path, index, row_format, **extra)