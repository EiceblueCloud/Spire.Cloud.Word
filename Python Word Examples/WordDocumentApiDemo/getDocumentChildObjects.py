import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.WordDocumentApi(configuration)

file_name = 'Template.docx'
extra = {'folder': "DocDocument"}
response = api.get_document_child_objects(file_name, **extra)