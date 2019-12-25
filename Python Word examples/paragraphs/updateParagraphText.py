import spirecloudword
from spirecloudword import ParagraphFormat, Color, Border, Borders
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.paragraphs_api.ParagraphsApi(configuration)

file_name = "Template.docx"
index = 1
node_path = "sections/0"
text = "Test Update Paragraph Text "
extra = {'folder': 'input', 'dest_file_path': 'output/UpdateParagraphText.docx'}
result = api.update_paragraph_text(file_name, node_path, index, text, **extra)







