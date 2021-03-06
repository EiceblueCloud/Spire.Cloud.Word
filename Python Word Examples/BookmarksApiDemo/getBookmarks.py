import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.bookmarks_api.BookmarksApi(configuration)

file_name = 'Bookmarks.docx'
extra = {'folder': 'input'}
result = api.get_bookmarks(file_name, **extra)