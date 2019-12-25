import spirecloudword
from spirecloudword.api.text_ranges_api import TextRangesApi
from spirecloudword.models.text_range_format import TextRangeFormat
from spirecloudword.models.font import Font
from spirecloudword.models.color import Color
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.text_ranges_api.TextRangesApi(configuration)

filename = "Template.docx"
paragraph_path = "sections/0/paragraphs/1"
index = 0
text_range_format = TextRangeFormat()
text_range_format._text = "E-iceblue"
text_range_format._font = Font(40, "Cooper Black", Color(100, 100, 100))
text_range_format._background_color = Color(150, 100, 200)
inputFolder = "input"
destFilePath = "output/TextRange/update_text_range.docx"
result = api.update_text_range(filename, paragraph_path, index, text_range_format, folder=inputFolder, dest_file_path=destFilePath)