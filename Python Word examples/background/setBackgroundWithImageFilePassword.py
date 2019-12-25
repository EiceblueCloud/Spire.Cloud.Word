import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.background_api.BackgroundApi(configuration)
file_name = 'SetBackgroundImageWithPassword.docx'
inputFolder = "input"
password = "123"
dest_file_path = "output/SetBackgroundWithImageFilePassword.docx"
result = api.set_background_image_with_img_file(file_name, "E:\image\image1.jpg", folder=inputFolder, password=password, dest_file_path=dest_file_path)


