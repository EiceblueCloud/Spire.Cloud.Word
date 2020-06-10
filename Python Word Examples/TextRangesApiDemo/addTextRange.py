import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TextRangesApi(configuration)

file_name = 'Template.docx'
paragraph_path = 'Section/0/Body/0/Paragraph/0'
text = 'AddTextRange'
extra_text = { 'index_in_paragraph': 0,  'folder': "input",'dest_file_path': 'output/AddTextRange.docx'}
result =api.add_text_range(file_name, paragraph_path, text, **extra_text)