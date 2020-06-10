import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = "convert.docx"
target_format = 'postScript' #Available values: doc, docx, wordml, wordxml, odt, docm, dotm, dotx, dot, rtf, pdf, xps, epub, pcl, postScript
dest_file_path = 'output/convert.ps'
extra = {'folder': 'input'}
api.convert(file_name, target_format, dest_file_path, **extra)
