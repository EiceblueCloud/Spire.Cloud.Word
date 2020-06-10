import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = "ConvertToHtml.docx"
extra = {'folder': 'input'}
dest_file_path = 'output/ConvertToHtml/'
api.convert_to_html(file_name, dest_file_path, **extra)