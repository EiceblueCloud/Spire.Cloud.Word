import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ParagraphsApi(configuration)

file_name = 'UpdateParagraphText.docx'
node_path = 'Section/0/Body/0'
index = 2
text = 'Test UpdateParagraphText '
extra = {'folder': "input", 'dest_file_path': 'output/UpdateParagraphText_output.docx'}
result = api.update_paragraph_text(file_name, node_path, index, text, **extra)