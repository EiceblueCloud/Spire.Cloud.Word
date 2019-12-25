import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.models.table_cell_format import TableCellFormat
from spirecloudword.models.color import Color
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
index = 0
table_row_path = "sections/0/tables/0/rows/0"
cell_format = TableCellFormat()
cell_format._background_color = Color(100, 100, 100)
cell_format._width = 80
inputFolder = "input"
outputFilePath = "output/Tables/update_table_cell_format.docx"
result = api.update_table_cell_format(filename, table_row_path, index, cell_format, folder=inputFolder, dest_file_path=outputFilePath)
