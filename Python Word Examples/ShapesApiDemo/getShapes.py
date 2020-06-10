import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ShapesApi(configuration)

file_name = 'Shape.docx'
extra = {'folder': "input"}
result =api.get_shapes(file_name, **extra)