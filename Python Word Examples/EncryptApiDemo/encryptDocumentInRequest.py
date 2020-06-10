import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.encrypt_api.EncryptApi(configuration)

file_name = 'EncryptDocumentInRquest.docx'
input_file = "D:/input/"
extra = {'new_password': '123456'}
result = api.encrypt_document_in_request(input_file, **extra)