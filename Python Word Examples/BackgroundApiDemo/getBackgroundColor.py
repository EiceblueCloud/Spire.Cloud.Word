import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

fileName = 'SetBackgroundColor.docx'
folder = 'input'
color = api.get_background_color(name=fileName, folder=folder)