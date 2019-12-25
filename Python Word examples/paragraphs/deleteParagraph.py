import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.paragraphs_api.ParagraphsApi(configuration)

file_name = "Template.docx"
node_path = "sections/0"
index = 2
extra = {'folder': 'input', 'dest_file_path': 'output/DeleteParagraph.docx'}
result = api.delete_paragraph(file_name, node_path, index, **extra)








