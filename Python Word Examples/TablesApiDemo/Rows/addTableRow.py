import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Template.docx'
table_path = 'Section/0/Body/0/Table/6'
extra = {'index_of_table_row': 0,'cells_count': 5,'folder': "input", 'dest_file_path': 'output/AddTableRow.docx'}
result = api.add_table_row(file_name, table_path, **extra)