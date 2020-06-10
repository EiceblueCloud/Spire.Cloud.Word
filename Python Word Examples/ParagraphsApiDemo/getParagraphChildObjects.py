import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ParagraphsApi(configuration)

file_name = "Template.docx"
node_path = "Section/0/Body/0"
index = 5
result = api.get_paragraph_child_objects(file_name, node_path, index, folder="input")
