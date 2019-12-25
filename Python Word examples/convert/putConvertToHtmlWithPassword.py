import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.convert_api.ConvertApi(configuration)
file_name = "Encrypt.docx"
target_format = "html"
inputFolder = "input"
outputFilePath = "output/ConvertToHtmlWithPassword.html"
password = "123"
result = api.convert_document(file_name, target_format, folder=inputFolder, dest_file_path=outputFilePath, password=password)



