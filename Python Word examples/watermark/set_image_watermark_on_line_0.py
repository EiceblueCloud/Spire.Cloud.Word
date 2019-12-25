import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "Template.docx"
inputFolder = "input"
input_image = "D:/data/Logo.png"
dest_file_path = "output/Watermark/set_image_watermark_on_line_0.docx"
result = api.set_image_watermark_on_line(filename, input_image, folder=inputFolder, washout=True, dest_file_path=dest_file_path)
