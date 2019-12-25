import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration
from spirecloudword.models.color import Color
from spirecloudword.models.font import Font
from spirecloudword.models.text_watermark import TextWatermark

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "Template.docx"
inputFolder = "input"
outputPath = "output/Watermark/set_text_watermark_Diagonal.docx"
watermarks = TextWatermark("E-iceblue")
watermarks.layout = "Diagonal"
watermarks._font = Font(60, "CG Omega", Color(255, 192, 203))
result = api.set_text_watermark(filename, watermarks, folder=inputFolder, dest_file_path=outputPath)