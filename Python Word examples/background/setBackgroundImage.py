import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.background_api.BackgroundApi(configuration)
file_name = "BackgroundSample.docx"
image_path = "input/Logo.png"
destFilePath = "/output/SetBackgroundImage.docx"
result = api.set_backgroud_image(file_name, image_path, folder="input", dest_file_path=destFilePath)


