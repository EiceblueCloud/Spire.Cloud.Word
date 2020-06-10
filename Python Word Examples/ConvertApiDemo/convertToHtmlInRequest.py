import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

file_name = "D:/input/ConvertToHtmlInRequest.docx"
result = api.convert_to_html_in_request(file_name)
