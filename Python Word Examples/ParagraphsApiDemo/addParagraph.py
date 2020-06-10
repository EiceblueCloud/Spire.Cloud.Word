import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ParagraphsApi(configuration)

file_name = "AddParagraph.docx"
node_path = "Section/0/Body/0"
extra = {'folder': 'input','index_of_paragraph': 0,'text': 'E-iceblue','dest_file_path': 'output/AddParagraph_output.docx'}
api.add_paragraph(file_name, node_path, **extra)