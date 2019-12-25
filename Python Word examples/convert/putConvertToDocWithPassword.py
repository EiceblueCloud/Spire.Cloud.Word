import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.convert_api.ConvertApi(configuration)
file_name = "Encrypt.docx"
target_format = "doc"
result = api.convert_document(file_name, target_format, **extra)
inputFolder = "input"
outputFilePath = "output/ConvertToDoc.doc"
password = "123"
result = api.convert_document(file_name, target_format, folder=inputFolder, dest_file_path=outputFilePath, password=password)




