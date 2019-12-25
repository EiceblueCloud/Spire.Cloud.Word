import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
table_row_path = "sections/0/tables/0/rows/5"
index_of_table_cell = "1"
inputFolder = "input"
outputFilePath = "output/Tables/add_table_cell.docx"
result = api.add_table_cell(filename, table_row_path, index_of_table_cell=index_of_table_cell, folder=inputFolder, dest_file_path=outputFilePath)

