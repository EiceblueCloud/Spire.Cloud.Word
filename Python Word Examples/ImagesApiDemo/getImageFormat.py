import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.images_api.ImagesApi(configuration)

file_name = 'Image.docx'
paragraph_path = 'Section/0/Body/0/Paragraph/1'
index = 0
folder = 'input'
result = api.get_image_format(file_name, paragraph_path, index, folder)