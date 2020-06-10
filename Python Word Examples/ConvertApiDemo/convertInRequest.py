import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = "D:/input/convert.docx"
target_format = 'postScript' #Available values: doc, docx, wordml, wordxml, odt, docm, dotm, dotx, dot, rtf, pdf, xps, epub, pcl, postScript
extra = {'password': ''}
result = api.convert_in_request(file_name, target_format, **extra)