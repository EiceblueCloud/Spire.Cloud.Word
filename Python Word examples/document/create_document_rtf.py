import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.word_document_api.WordDocumentApi(configuration)

outputPath = "output/WordDocument"
file_format = "rtf"
filename = "create_document_rtf"
result = api.create_document(file_format, filename, dest_folder=outputPath)


