import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.watermarks_api.WatermarksApi(configuration)

filename = "ImgWatermark.docx"
folder = "input"
dest_file_path = "output/Watermark/delete_image_watermark.docx"
result = api.delete_watermark(filename, folder=folder, dest_file_path=dest_file_path)
