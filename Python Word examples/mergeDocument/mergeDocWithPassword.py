import spirecloudword
from spirecloudword import MergingFile
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.merge_api.MergeApi(configuration)

file_name = "OriginalEncrypt.docx"
merging_file_list = [MergingFile('File1.docx', 'input', None)]
extra = {'folder': 'input', 'password': '123', 'dest_file_path': 'output/MergeDocumentWithPassword.docx'}
result = api.merge_document(file_name, merging_file_list, **extra)







