import spirecloudword
from spirecloudword import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey, baseUrl)
api = spirecloudword.api.bookmarks_api.BookmarksApi(configuration)

file_name = 'AddBookmark.docx'
start_paragraph_path = 'Section/0/Body/0/Paragraph/0'
start_index_in_paragraph = 0
end_paragraph_path = 'Section/0/Body/0/Paragraph/2'
end_index_in_paragraph = 0
bookmark_name = 'Text_Bookmark'
extra = {'folder': 'input',
         'dest_file_path': 'output/AddBookmark.docx'}
result = api.add_bookmark(file_name, start_paragraph_path, start_index_in_paragraph,
                               end_paragraph_path, end_index_in_paragraph, bookmark_name, **extra)