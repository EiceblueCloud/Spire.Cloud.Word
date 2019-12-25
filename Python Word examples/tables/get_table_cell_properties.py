import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
inputFolder = "input"
table_row_path = "sections/0/tables/0/rows/2"
index = 0
result = api.get_table_cell_properties(filename, table_row_path, index, folder=inputFolder)
