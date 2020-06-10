import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = "ConvertToVectorgraph.docx"
image_type = "wmf" #Available values : wmf, svg
dest_file_path = 'output/ConvertToVectorgraph_WMF/'
extra = {'folder': 'input'}
api.convert_to_vectorgraph(file_name, image_type, dest_file_path, **extra)