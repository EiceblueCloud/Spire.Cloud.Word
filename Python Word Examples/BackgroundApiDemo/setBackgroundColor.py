import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

fileName = 'Rachel.docx'
color = Color(127, 255, 170)
folder = 'input'
destFilePath = 'output/SetBackgroundColor.docx'
result = api.set_background_color(name=fileName, folder=folder, color=color, dest_file_path=destFilePath)