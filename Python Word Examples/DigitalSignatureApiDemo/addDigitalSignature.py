import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.digital_signature_api.DigitalSignatureApi(configuration)

file_name = 'AddDigitalSignature.docx'
pfx_file = 'D:/input/Gary.pfx'
secure_password = 'e-iceblue'
dest_file_path = 'digitalSignature/AddDigitalSignature.docx'
extra = {'folder': 'input'}
api.add_digital_signature('Template.docx', pfx_file, secure_password, dest_file_path, **extra)