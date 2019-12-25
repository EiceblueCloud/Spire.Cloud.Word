import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "Encrypt.docx"
inputFolder = "input/"
password = "123"
outputPath = "output/Watermark/set_image_watermark_password_500.docx"

extra = {"folder": inputFolder,
         "scaling": 500,
         "washout": True,
         "password": password,
         "dest_file_path": outputPath}
result = api.set_image_watermark(filename, input_image="logo.png", **extra)

