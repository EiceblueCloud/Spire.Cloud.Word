import spirecloudword
from spirecloudword import MailMergeData
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.mail_merge_api.MailMergeApi(configuration)

file_name = "MailMerge.doc"
merging_list = [MailMergeData('Contact Name', 'E-iceblue'), MailMergeData('Fax', '123456789'),
                MailMergeData('Date', '2019-10-16')]
extra = {'folder': 'input',
         'dest_file_path': 'output/MailMerge.doc'}
api.mail_merge(file_name, merging_list, **extra)







