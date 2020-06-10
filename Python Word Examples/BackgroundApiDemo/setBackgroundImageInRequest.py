import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

filename = 'SetBackgroundImageInRequest.docx'
folder = 'input'
imgePath = 'D:/input/Logo.png'
dest_file_path = 'output/SetBackgroundImageInRequest.docx'

result = api.set_background_image_in_request(name=filename, folder=folder, input_image=imgePath,
                                             dest_file_path=dest_file_path)
