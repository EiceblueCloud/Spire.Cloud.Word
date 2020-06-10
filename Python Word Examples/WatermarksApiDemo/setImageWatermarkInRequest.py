import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.WatermarksApi(configuration)

file_name = 'Encrypt.docx'
input_image = 'D:/input/Logo.png'
dest_file_path = 'output/SetImageWatermarkInRequest_true.docx'
#Just moving "'password': '123'" if there is no password.
extra = {'folder':"input", 'scaling': 120,'washout': True, 'password': '123'}
result = api.set_image_watermark_in_request(file_name, input_image, dest_file_path, **extra)