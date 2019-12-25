import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
node_path = "sections/0"
rows_count = 6
columns_count = 6
inputFolder = "input"
destFilePath = "output/Tables/add_table.docx"
api.add_table(filename, node_path, rows_count, columns_count, index_of_table=1, folder=inputFolder, dest_file_path=destFilePath)