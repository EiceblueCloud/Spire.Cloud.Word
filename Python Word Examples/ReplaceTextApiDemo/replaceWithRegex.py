import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ReplaceTextApi(configuration)

file_name = 'ReplaceText.docx'
regex = '\\#\\w+\\b'
new_value = 'E-iceblue'
extra = {'folder': "input", 'dest_file_path': 'output/ReplaceWithRegex.docx'}
result =api.replace_with_regex(file_name, regex, new_value, **extra)
