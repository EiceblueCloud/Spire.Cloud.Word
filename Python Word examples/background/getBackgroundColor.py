import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.background_api.BackgroundApi(configuration)
color = api.get_backgroud_color("BackgroundSample.docx", folder="input")


