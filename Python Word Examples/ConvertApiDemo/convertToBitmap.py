import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = 'ConvertToBitmap.docx'
image_format = 'jpeg' #Available values : jpeg, bmp, png
dest_file_path = 'output/ConvertToBitmap_jpeg/'
extra = {'folder': 'input'}
api.convert_to_bitmap(file_name, image_format, dest_file_path, **extra)