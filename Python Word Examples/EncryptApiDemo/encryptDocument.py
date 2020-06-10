import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.encrypt_api.EncryptApi(configuration)

file_name = 'EncryptDocument.docx'
folder = 'input'
new_password='123'
dest_file_path = 'output/EncryptDocument.docx'
api.encrypt_document(file_name, new_password=new_password, folder=folder, dest_file_path=dest_file_path)