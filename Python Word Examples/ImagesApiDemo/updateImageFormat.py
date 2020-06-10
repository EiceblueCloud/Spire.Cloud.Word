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
format = ImageFormat(width=400, height=400, rotation=20, vertical_position=50, horizontal_position=50);
dest_file_path = 'output/UpdateImageFormat.docx'
folder = 'input'
api.update_image_format(file_name, paragraph_path, index, dest_file_path, format, folder)