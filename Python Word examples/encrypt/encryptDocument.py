import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.encrypt_api.EncryptApi(configuration)

file_name = "Template.docx"
extra = {
    'new_password': '123',
    'folder': "input",
    'dest_file_path': 'output/EncryptDocument1.docx'}
result1 = api.encrypt_document(file_name, **extra)





