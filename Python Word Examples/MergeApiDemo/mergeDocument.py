import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.merge_api.MergeApi(configuration)

file_name = "Template.docx"
merging_file_list = []
merging_file_list.append(MergingFile('input/Table.docx'))
extra = {'dest_file_path': 'output/MergeDocument.docx',
         'folder': 'input'}
api.merge_document(file_name, merging_file_list, **extra)