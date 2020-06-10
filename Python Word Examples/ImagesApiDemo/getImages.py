import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.images_api.ImagesApi(configuration)

file_name = 'Image.docx'
folder = 'input'
result = api.get_images(file_name, folder)