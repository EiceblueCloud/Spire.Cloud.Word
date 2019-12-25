import spirecloudword
from spirecloudword.models.color import *
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

file_name = "BackgroundSample.docx"
color = Color(127, 255, 170)
inputFolder = "input"
destFilePath = "output/SetBackgroundColor.docx"
result = api.set_backgroud_color(file_name, color, folder=inputFolder, dest_file_path=destFilePath)


