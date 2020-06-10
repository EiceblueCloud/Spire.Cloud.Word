import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.images_api.ImagesApi(configuration)

file_name = 'Image.docx'
input_image = 'D:/input/image.png'
paragraph_path = 'Section/0/Body/0/Paragraph/0'
extra = {
    'folder': 'input',
    'index_in_paragraph': 0,
    'dest_file_path': 'output/AddImageInRequest.docx'}
api.add_image_in_request('ImageTest.docx', input_image, paragraph_path, **extra);