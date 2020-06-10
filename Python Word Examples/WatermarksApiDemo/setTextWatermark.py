import spirecloudword
from spirecloudword import TextWatermark, Font, Color
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.WatermarksApi(configuration)

file_name = 'test.docx'
watermarks = TextWatermark('E-iceblue')
watermarks.layout = 'Horizontal'
watermarks._font = Font(60, 'Cooper Black', Color(100, 100, 100))
extra = {'folder': "input", 'dest_file_path': 'output/SetTextWatermark_Horizontal.docx'}
result = api.set_text_watermark(file_name, watermarks, **extra)