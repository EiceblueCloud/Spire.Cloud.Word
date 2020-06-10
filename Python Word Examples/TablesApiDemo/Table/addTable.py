import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'AddTable.docx'
node_path = 'Section/0/Body/0'
rows_count = 6
columns_count = 6
extra = {'index_of_table': 0,'folder': "input",'dest_file_path': 'Tables/AddTable_1_Temp.docx'}
result = api.add_table(file_name, node_path, rows_count, columns_count, **extra)