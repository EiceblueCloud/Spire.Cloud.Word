import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ParagraphsApi(configuration)

file_name = 'GetParagraphs.docx'
node_path = "Section/0/Body/0"
extra = {'folder': "input"}
result =api.get_paragraphs(file_name, **extra)