import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.digital_signature_api.DigitalSignatureApi(configuration)

file_name = 'Template.docx'
pfx_file = 'D:/input/Gary.pfx'
secure_password = 'e-iceblue'
extra = {'folder': 'input',
         'dest_file_path': 'output/AddDigitalSignatureInRequest.docx'}
result = api.add_digital_signature_in_request(file_name, pfx_file, secure_password, **extra)