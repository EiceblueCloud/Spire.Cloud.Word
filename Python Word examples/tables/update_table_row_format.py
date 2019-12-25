import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.models.table_row_format import TableRowFormat
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
index = 7
table_path = "sections/0/tables/0"
row_format = TableRowFormat()
row_format._height = 50
row_format._height_type = "AtLeast"
row_format._break_across_pages = False
row_format._header = True
inputFolder = "input"
destFilePath = "output/Tables/update_table_row_format.docx"
result = api.update_table_row_format(filename, table_path, index, row_format, folder=inputFolder, dest_file_path=destFilePath)
