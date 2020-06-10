import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.WatermarksApi(configuration)

file_name = 'ImgWatermark.docx'
#Just moving "'password': '123'" if there is no password.
extra = {'folder': "input", 'password': '123', 'dest_file_path': 'output/DeleteImgWatermarkPw.docx'}
result = api.delete_watermark(file_name, **extra)