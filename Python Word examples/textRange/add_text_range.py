import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration
from spirecloudword.api.text_ranges_api import TextRangesApi
from spirecloudword.models.color import Color
from spirecloudword.models.font import Font
from spirecloudword.models.text_range_format import TextRangeFormat

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.text_ranges_api.TextRangesApi(configuration)

filename = "Template.docx"
paragraph_path = "sections/0/paragraphs/0"
text_range = TextRangeFormat()
text_range._text = "E-iceblue"
text_range._background_color = Color(0, 255, 255)
text_range._font = Font(40, "Cooper Black", Color(100, 100, 100))
destFilePath = "output/TextRange/add_text_range.docx"
result = api.add_text_range(filename, paragraph_path, text_range, index_in_paragraph=0, folder="input", dest_file_path=destFilePath)


