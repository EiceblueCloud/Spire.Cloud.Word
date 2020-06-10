import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.WordDocumentApi(configuration)

dest_folder = 'output'
#supports formats: docx/doc/rtf/docm/dot/dotx/dotm
result = api.create_document('docx', 'CreateDocument', dest_folder=dest_folder)