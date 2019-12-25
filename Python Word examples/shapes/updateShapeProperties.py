import spirecloudword
from spirecloudword import ShapeFormat, Color
from spirecloudword.configuration import Configuration as WordConfiguration

appId = "your id"
appKey = "your key"

configuration = WordConfiguration(appId, appKey)
api = spirecloudword.api.shapes_api.ShapesApi(configuration)

file_name = "AddShapes.docx"
paragraph_path = "sections/0/paragraphs/0"
index = 0
shape_properties = ShapeFormat(50, 50, "Octagon")
shape_properties._horizontal_origin = "LeftMarginArea"
shape_properties._vertical_origin = "Paragraph"
shape_properties._vertical_position = 80
shape_properties._horizontal_position = 80
shape_properties._fill_color = Color(100, 100, 100)
shape_properties._rotation = 10
shape_properties._stroke_weight = 2
shape_properties._stroke_color = Color(0, 206, 209)
shape_properties._text_wrapping_type = "Both"
shape_properties._text_wrapping_style = "InFrontOfText"
shape_properties._z_order = 1
extra = {'folder': 'input', 'dest_file_path': 'output/UpdateShapeProperties.docx'}
result = api.update_shape_properties(file_name, paragraph_path, index, shape_properties, **extra)





