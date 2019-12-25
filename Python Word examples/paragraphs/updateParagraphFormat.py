import spirecloudword
from spirecloudword import ParagraphFormat, Color, Border, Borders
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.paragraphs_api.ParagraphsApi(configuration)

file_name = "Template.docx"
node_path = "sections/0"
index = 0
paragraph_format = ParagraphFormat()
paragraph_format._horizontal_alignment = "Center"
paragraph_format._left_or_inner_indent = 20
paragraph_format._right_or_outside_indent = 10
paragraph_format._mirror_indents = True
paragraph_format._first_line_indent = 30
paragraph_format._background_color = Color(60, 179, 113)
paragraph_format._before_spacing = 40
paragraph_format._after_spacing = 40
paragraph_format._before_auto_spacing = True
paragraph_format._after_auto_spacing = True
paragraph_format._line_space = 50
paragraph_format._line_spacing_rule = "Multiple"
paragraph_format._word_wrap = False
border = Border()
border._border_type = "Dot"
paragraph_format._borders = Borders(border)
extra = {'folder': 'input', 'dest_file_path': 'output/UpdateParagraphFormat.docx'}
result = api.update_paragraph_format(file_name, node_path, index, paragraph_format, **extra)







