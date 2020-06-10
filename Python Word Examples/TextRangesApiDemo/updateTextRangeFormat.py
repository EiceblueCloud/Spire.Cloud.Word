import spirecloudword
from spirecloudword import TextRangeFormat, Color, Font
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.TextRangesApi(configuration)

file_name = 'Template.docx'
paragraph_path = "Section/0/Body/0/Paragraph/1"
index = 0
text_range_format = TextRangeFormat()
text_range_format._text = 'E-iceblue'
text_range_format._font = Font(40, 'Cooper Black', Color(100, 100, 100))
extra = {'folder': "input", 'dest_file_path': 'output/UpdateTextRangeFormat.docx'}
result = api.update_text_range_format(file_name, paragraph_path, index, text_range_format, **extra)