import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.background_api.BackgroundApi(configuration)

file_name = 'DeleteBackgroundSample.docx'
inputFolder = "input"
dest_file_path = "output/deleteBackground.docx"
result = api.delete_background(file_name, folder=inputFolder, dest_file_path=dest_file_path)


