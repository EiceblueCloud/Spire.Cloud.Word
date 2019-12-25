import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.bookmarks_api.BookmarksApi(configuration)

file_name = "AddBookmrakEncrypt.docx"
start_paragraph_path = "sections/0/paragraphs/0"
start_index_in_paragraph = 0
end_paragraph_path = "sections/0/paragraphs/2"
end_index_in_paragraph = 0
bookmark_name = "Bookmark"
extra = {"folder": "input",
         "password": "123",
         "dest_file_path": "/output/AddBookmarkWithPassword.docx"}
result = api.add_bookmark(file_name, start_paragraph_path, start_index_in_paragraph,
                          end_paragraph_path, end_index_in_paragraph, bookmark_name, **extra)
