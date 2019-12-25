import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.background_api.BackgroundApi(configuration)
file_name = "BackgroundSample.docx"
folder = "input"
dest_file_path = "/output/SetBackgroundWithImageFile.docx"
image_path = "E:/image/image1.jpg"
result = api.set_background_image_with_img_file(file_name, image_path, folder=folder, dest_file_path=dest_file_path)
