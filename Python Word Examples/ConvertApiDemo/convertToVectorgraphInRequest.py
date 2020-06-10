import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = 'D:/input/ConvertToVectorgraphInRequest.docx'
image_type = 'wmf' #Available values : wmf, svg
result = api.convert_to_vectorgraph_in_request(file_name, image_type)