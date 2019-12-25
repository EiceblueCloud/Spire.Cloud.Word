import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.sections_api.SectionsApi(configuration)

file_name = "Template.docx"
section_index = 0
result = api.get_page_setup(file_name, section_index, folder="input")








