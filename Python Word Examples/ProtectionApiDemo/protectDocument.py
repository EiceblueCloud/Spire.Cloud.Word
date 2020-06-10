import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ProtectionApi(configuration)

file_name = 'Template.docx'
#supports types: AllowOnlyReading/AllowOnlyComments/AllowOnlyFormFields/AllowOnlyRevisions/NoProtection
protection_type = 'AllowOnlyReading'
extra = {'folder': "input", 'protectiong_pwd': '123456', 'dest_file_path': 'output/ProtectDocument_AllowOnlyReading.docx'}
result =api.protect_document(file_name, protection_type, **extra)

