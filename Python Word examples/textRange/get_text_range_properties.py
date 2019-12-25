import spirecloudword
from spirecloudword.api.text_ranges_api import TextRangesApi
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.text_ranges_api.TextRangesApi(configuration)

filename = "Template.docx"
paragraph_path = "sections/0/paragraphs/0"
index = 0
result = api.get_text_range_properties(filename, paragraph_path, index, folder="input")
