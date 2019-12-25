import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "EncryptImgWatermark.docx"
dest_file_path = "output/Watermark/delete_image_watermark_password.docx"
result = api.delete_watermark(filename, folder="input", password="123", dest_file_path=dest_file_path)

