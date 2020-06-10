import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TextRangesApi(configuration)

file_name = 'Template.docx'
paragraph_path = "Section/0/Body/0/Paragraph/0"
index = 0
text = 'E-iceblue test textRange'
extra = {'folder': "input",'dest_file_path': 'output/UpdateTextRangeText.docx'}
result =api.update_text_range_text(file_name, paragraph_path, index, text, **extra)