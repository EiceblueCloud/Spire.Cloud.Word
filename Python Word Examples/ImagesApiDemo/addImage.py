import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.images_api.ImagesApi(configuration)

file_name = 'Image.docx'
image_path = 'input/image.png'
paragraph_path = 'Section/0/Body/0/Paragraph/0'
extra = {
    'folder': 'input',
    'index_in_paragraph': 0,
    'dest_file_path': 'output/AddImage.docx'}
api.add_image(file_name, image_path, paragraph_path, **extra);