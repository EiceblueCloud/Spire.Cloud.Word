import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
index = 0
node_path = "sections/0"
inputFolder = "input"
destFilePath = "output/Tables/delete_table.docx"
result = api.delete_table(filename, node_path, index, folder=inputFolder, dest_file_path=destFilePath)
