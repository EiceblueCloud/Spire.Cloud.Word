import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Table.docx'
node_path = 'Section/0/Body/0'
index = 0
extra = {'folder': "input"}
result = api.get_table_rows(file_name, node_path, index, **extra)