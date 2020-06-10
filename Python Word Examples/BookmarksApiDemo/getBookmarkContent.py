import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.bookmarks_api.BookmarksApi(configuration)

file_name = 'bookmark.docx'
bookmark_name = 'Test'
extra = {'folder': 'input'}
result = api.get_bookmark_content(file_name, bookmark_name, **extra)