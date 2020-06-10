import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Table.docx'
index = 0
node_path = 'Section/0/Body/0'
result = api.get_table_format(file_name, node_path, index, folder="input")