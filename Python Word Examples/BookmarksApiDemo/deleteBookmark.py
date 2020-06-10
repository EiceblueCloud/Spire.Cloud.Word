import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.bookmarks_api.BookmarksApi(configuration)

file_name = 'Bookmarks.docx'
bookmark_name = 'Test'
extra = {'folder': 'input',
         'dest_file_path': 'output/DeleteBookmark.docx'}
api.delete_bookmark(file_name, bookmark_name, **extra)
