import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "EncryptTextWatermark.docx"
dest_file_path = "output/Watermark/delete_text_watermark.doc"
result = api.delete_watermark(filename, folder="input", password="123", dest_file_path=dest_file_path)