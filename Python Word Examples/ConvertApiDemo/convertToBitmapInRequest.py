import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = 'D:/input/ConvertToBitmapInRequest.docx'
image_format = 'jpeg' #Available values : jpeg, bmp, png
result = api.convert_to_bitmap_in_request(file_name, image_format)