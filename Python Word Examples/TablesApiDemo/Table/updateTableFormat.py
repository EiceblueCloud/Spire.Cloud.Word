import spirecloudword
from spirecloudword import TableFormat, Border, Color, Borders
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Table.docx'
index = 0
node_path = 'Section/0/Body/0'
properties = TableFormat()
properties._bidi = True
border = Border()
border._border_type = 'ThinThickThinMediumGap'
border._color = Color(255, 25, 1)
border._line_width = 10
properties._borders = Borders(border)
extra = {'folder': "input", 'dest_file_path': 'output/UpdateTableFormat_3.docx'}
result =api.update_table_format(file_name, node_path, index, properties, **extra)