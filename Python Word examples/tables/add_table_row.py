import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

filename = "Template.docx"
folder = "input"
dest_file_path = "output/Tables/add_table_row.docx"
table_path = "sections/0/tables/0"
result = api.add_table_row(filename, table_path, folder, dest_file_path, index_of_table_row=5, cells_count=2)