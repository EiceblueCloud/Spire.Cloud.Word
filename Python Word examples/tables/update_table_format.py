import spirecloudword
from spirecloudword.api.tables_api import TablesApi
from spirecloudword.models.table_format import TableFormat
from spirecloudword.models.color import Color
from spirecloudword.models.borders import Borders
from spirecloudword.models.border import Border
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.tables_api.TablesApi(configuration)

name = "Template.docx"
index = 0
node_path = "sections/0"
properties = TableFormat()
properties._bidi = True
border = Border()
border._border_type = "ThinThickThinMediumGap"
border._color = Color(255, 25, 1)
border._line_width = 10
properties._borders = Borders(border)
inputFolder = "input"
destFilePath = "output/Tables/update_table_format.docx"
result = api.update_table_format(name, node_path, index, properties, folder=inputFolder, dest_file_path=destFilePath)
