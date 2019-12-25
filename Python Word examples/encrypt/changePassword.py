import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.encrypt_api.EncryptApi(configuration)

file_name = "Encrypt.docx"
extra = {
    'folder': 'input',
    'old_password': '123',
    'new_password': '456',
    'dest_file_path': 'output/changePassword.docx'}
result = api.encrypt_document(file_name, **extra)





