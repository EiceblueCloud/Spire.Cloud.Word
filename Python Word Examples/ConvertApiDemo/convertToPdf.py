import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.convert_api.ConvertApi(configuration)

private_fonts = [PrivateFont("黑体", "input/simhei.ttf")]
extra = {'folder': 'input',
         'private_fonts': private_fonts,
         'dest_file_path': 'output/ConvertToPdf.pdf'}
api.convert_to_pdf('Template.docx', **extra)