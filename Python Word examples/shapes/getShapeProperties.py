import spirecloudword
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.shapes_api.ShapesApi(configuration)

file_name = "ShapeTemplate.docx"
paragraph_path = "sections/0/paragraphs/0"
index = 0
result = api.get_shape_properties(file_name, paragraph_path, index, folder="input")





