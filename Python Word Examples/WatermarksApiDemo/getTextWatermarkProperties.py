import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.WatermarksApi(configuration)

file_name = 'TextWatermark.docx'
#Just moving "'password': '123'" if there is no password.
result = api.get_text_watermark_properties(file_name, folder="input", password='123')