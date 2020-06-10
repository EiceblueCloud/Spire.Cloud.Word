import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Template.docx'
table_path = 'Section/0/Body/0/Table/6'
index = 2
result =api.get_table_row_format(file_name, table_path, index, folder="input")