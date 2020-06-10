import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ShapesApi(configuration)

file_name = 'Shape.docx'
paragraph_path = 'Section/0/Body/0/Paragraph/0'
index = 1
extra = {'folder': "input", 'dest_file_path': 'output/DeleteShape.docx'}
result = api.delete_shape(file_name, paragraph_path, index, **extra)