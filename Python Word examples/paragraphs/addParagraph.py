import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.paragraphs_api.ParagraphsApi(configuration)

file_name = "Template.docx"
node_path = "sections/0"
extra = {
    'folder': 'input',
    'index_of_paragraph': 1,
    'text': 'E-iceblue',
    'dest_file_path': 'output/AddParagraph_1.docx'}
api.add_paragraph(file_name, node_path, **extra)








