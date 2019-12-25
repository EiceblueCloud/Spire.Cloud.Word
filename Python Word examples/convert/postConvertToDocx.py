import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.convert_api.ConvertApi(configuration)
local_file = "E:\data\ToDocx.docx"
target_format = "docx"
result = api.convert_document_with_file(local_file, target_format)




