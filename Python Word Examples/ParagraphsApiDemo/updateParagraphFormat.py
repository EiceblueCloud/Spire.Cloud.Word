import spirecloudword
from spirecloudword import ParagraphFormat, Color, Border, Borders
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ParagraphsApi(configuration)

file_name = 'UpdateParagraphFormat.docx'
node_path = 'Section/0/Body/0'
index = 0
paragraph_format = ParagraphFormat()
#supports aligments: Distribute/Center/Left
paragraph_format._horizontal_alignment = 'Distribute'
paragraph_format._left_or_inner_indent = 20
paragraph_format._right_or_outside_indent = 10
paragraph_format._mirror_indents = False
paragraph_format._first_line_indent = 30
paragraph_format._background_color = Color(100, 100, 100)
paragraph_format._before_spacing = 40
paragraph_format._after_spacing = 40
paragraph_format._before_auto_spacing = False
paragraph_format._after_auto_spacing = False
paragraph_format._line_space = 50
#supports rules:Exactly/Multiple/AtLeast
paragraph_format._line_spacing_rule = 'Exactly'
paragraph_format._word_wrap = True
border = Border()
#supports types:Double/ThickThinSmallGap/Dot
border._border_type = 'Double'
borders = Borders()
borders._top_border = border
paragraph_format._borders = borders
extra = {'folder': "input", 'dest_file_path': 'output/UpdateParagraphFormat_output.docx'}
result = api.update_paragraph_format(file_name, node_path, index, paragraph_format,**extra)