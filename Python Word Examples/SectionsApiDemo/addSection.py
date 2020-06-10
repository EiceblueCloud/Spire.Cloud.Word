import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.SectionsApi(configuration)

file_name = 'Template.docx'
extra = { 'folder': "input", 'section_index': 2,'dest_file_path': 'output/AddSection.docx'}
result =api.add_section(file_name, **extra)