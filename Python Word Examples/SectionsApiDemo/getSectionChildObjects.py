import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.SectionsApi(configuration)

file_name = 'PageSetup.docx'
section_index = 0
result =api.get_section_child_objects(file_name, section_index, folder="input")