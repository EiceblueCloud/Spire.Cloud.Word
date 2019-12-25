import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
table_path = "sections/0/tables/0"
index = 0
inputFolder = "input"
outputFilePath = "output/Tables/delete_table_row.docx"
result = api.delete_table_row(filename, table_path, index, folder=inputFolder, dest_file_path=outputFilePath)
