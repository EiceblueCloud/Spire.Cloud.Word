import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ReplaceTextApi(configuration)

file = 'D:/ReplaceText.docx'
regex = '\\#\\w+\\b'
new_value = 'E-iceblue'
result = api.replace_with_regex_in_request(file, regex, new_value)