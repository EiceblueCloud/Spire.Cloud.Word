import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "Template.docx"
inputFolder = "input"
outputPath = "output/Watermark/set_image_watermark_on_line_true.docx"

extra = {"folder": inputFolder,
         "scaling": 120,
         "washout": True,
         "dest_file_path": outputPath}

result = api.set_image_watermark_on_line(filename, input_image="logo.png", **extra)

