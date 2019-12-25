import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "Encrypt.docx"
input_image = "D:/data/Logo.png"
inputFolder = "input"
password = "123"
destFilePath = "output/Watermark/set_image_watermark_false.docx"
result = api.set_image_watermark_on_line(filename, input_image, folder=inputFolder, password=password, scaling=120, washout=False, dest_file_path=destFilePath)


