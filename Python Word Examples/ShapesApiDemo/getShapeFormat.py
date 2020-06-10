import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ShapesApi(configuration)

file_name = 'Shape.docx'
paragraph_path = 'Section/0/Body/0/Paragraph/0'
index = 12
result = api.get_shape_format(file_name, paragraph_path, index, folder="input")