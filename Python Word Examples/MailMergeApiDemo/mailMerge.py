import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.mail_merge_api.MailMergeApi(configuration)

file_name = 'MailMergeFormField.doc'
merging_list = []
merging_list.append(MailMergeData('Contact Name', 'E-iceblue'))
merging_list.append(MailMergeData('Fax', '123456789'))
merging_list.append(MailMergeData('Date', '2019-10-16'))
dest_file_path = 'output/MailMerge.doc'
extra = {'folder': 'input'}
result = api.mail_merge(file_name, dest_file_path, merging_list, **extra)