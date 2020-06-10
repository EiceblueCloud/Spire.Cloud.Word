import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.WatermarksApi(configuration)

filename = 'Template.docx'
inputimg = 'images/Background.png'
#Just moving "'password': '123'" if there is no password.
extra = {'folder': "input",'scaling': 120,'washout': True,'password': '123','dest_file_path': 'output/SetImageWatermark.docx'}
result = api.set_image_watermark(filename, inputimg, **extra)