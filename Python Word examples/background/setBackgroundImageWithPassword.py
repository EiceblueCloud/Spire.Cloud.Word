import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

file_name = "SetBackgroundImageWithPassword.docx"
inputFolder = "input"
password = "123"
image_path = "/input/Logo.png"
destFilePath = "/output/setBackgroundImageWithPassword.docx"
result = api.set_backgroud_image(file_name, image_path, folder=inputFolder, password=password, dest_file_path=destFilePath)



