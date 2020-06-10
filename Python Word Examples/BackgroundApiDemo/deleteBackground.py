import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

filename = 'background.docx'
dest_file_path = 'output/DeleteBackground.docx'
extra = {'folder': "input",
         'dest_file_path': dest_file_path}
result = api.delete_background(filename, **extra)
