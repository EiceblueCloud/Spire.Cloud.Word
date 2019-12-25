import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.paragraphs_api.ParagraphsApi(configuration)

file_name = "Template.docx"
node_path = "sections/0"
index = 1
result = api.get_paragraph_format(file_name, node_path, index, folder="input")







