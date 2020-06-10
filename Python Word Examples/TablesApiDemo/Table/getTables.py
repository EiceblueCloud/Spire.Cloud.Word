import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TablesApi(configuration)

file_name = 'Table.docx'
extra = {'folder': "input"}
result = api.get_tables(file_name, **extra)