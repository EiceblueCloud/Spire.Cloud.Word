import spirecloudword
from spirecloudword import LineNumber, PageSetup, Margin
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.SectionsApi(configuration)

file_name = 'PageSetup.docx'
section_index = 0
linenumber = LineNumber(start_value=1, step=2)
#supports modes:Continuous/RestartPage/RestartSection
linenumber._restart_mode = 'Continuous'
linenumber._distance_from_text = 20
page_setup = PageSetup()
page_setup._page_width = 400
page_setup._page_height = 500
page_setup._page_margin = Margin(20, 20, 20, 20)
#supports orientations:Landscape/Portrait
page_setup._orientation = 'Landscape'
page_setup._linenumber = linenumber
extra = {'folder': "input", 'dest_file_path': 'output/UpdatePageSetup.docx'}
result =api.update_page_setup(file_name, section_index, page_setup, **extra)