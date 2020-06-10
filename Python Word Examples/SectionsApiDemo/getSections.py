import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.SectionsApi(configuration)

file_name = 'PageSetup.docx'
extra = {'folder': "input"}
result = api.get_sections(file_name, **extra)