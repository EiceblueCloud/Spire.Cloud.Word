import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

filename = 'SetBackgroundImage.docx'
folder = 'input'
imgePath = "input/Logo.png"
destFilePath = "output/SetBackgroundImage.docx"

result = api.set_background_image(name=filename,folder=folder, imge_path=imgePath, dest_file_path=destFilePath)