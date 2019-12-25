import spirecloudword
from spirecloudword import LineNumber, PageSetup, Margin
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.sections_api.SectionsApi(configuration)

file_name = "Template.docx"
section_index = 0
linenumber = LineNumber(start_value=2, step=2)
linenumber._restart_mode = "RestartSection"
linenumber._distance_from_text = 0
page_setup = PageSetup()
page_setup._page_width = 800
page_setup._page_height = 500
page_setup._page_margin = Margin(50, 50, 70, 50)
page_setup._orientation = 'Portrait'
page_setup._linenumber = linenumber
extra = {'folder': 'input', 'dest_file_path': 'output/UpdatePageSetup.docx'}
api.update_page_setup(file_name, section_index, page_setup, **extra)





