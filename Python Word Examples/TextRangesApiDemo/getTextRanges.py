import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TextRangesApi(configuration)

file_name = 'Template.docx'
extra = {'folder': "input"}
paragraph_path = 'Section/0/Body/0/Paragraph/0'
result = api.get_text_ranges(file_name, paragraph_path, **extra)