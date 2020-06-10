import spirecloudword
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ReplaceTextApi(configuration)

file_name = 'ReplaceText.docx'
old_value = '#test'
new_value = 'E-iceblue'
extra = {'folder': "input", 'match_case': 'true', 'match_whole_word': 'true', 'replace_first': 'false','dest_file_path': 'output/ReplaceWithText_true_true_false.docx'}
result =api.replace_with_text(file_name, old_value, new_value, **extra)