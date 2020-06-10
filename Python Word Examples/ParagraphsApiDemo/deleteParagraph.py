import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ParagraphsApi(configuration)

file_name = "Template.docx"
node_path = "Section/0/Body/0"
index = 2
extra = {'folder': 'input', 'dest_file_path': 'output/DeleteParagraph.docx'}
result = api.delete_paragraph(file_name, node_path, index, **extra)