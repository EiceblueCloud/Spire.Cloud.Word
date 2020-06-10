import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ReplaceTextApi(configuration)

file = 'D:/ReplaceText.docx'
old_value = '#test'
new_value = 'E-iceblue'
extra = {'match_case': 'true', 'match_whole_word': 'false', 'replace_first': 'true'}
result = api.replace_with_text_in_request(file, old_value, new_value, **extra)