import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ProtectionApi(configuration)

file = 'D:/Template.docx'
#supports types: AllowOnlyReading/AllowOnlyComments/AllowOnlyFormFields/AllowOnlyRevisions/NoProtection
protection_type = 'AllowOnlyReading'
extra = {'protectiong_pwd': '123456'}
result = api.protect_document_in_request(file, protection_type, **extra)