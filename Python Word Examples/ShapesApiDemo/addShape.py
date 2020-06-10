import spirecloudword
from spirecloudword import ShapeFormat, Color
from spirecloudword.configuration import *

appId = "your id"
appKey = "your key"
baseUrl = "https://api.e-iceblue.cn"
configuration = Configuration(appId, appKey,baseUrl)
api= spirecloudword.api.ShapesApi(configuration)

file_name = 'Summary of Science.docx'
paragraph_path = 'Section/0/Body/0/Paragraph/2'
shape_properties = ShapeFormat(40, 40, 'Rectangle')
shape_properties._horizontal_origin = 'Page'
shape_properties._vertical_origin = 'Paragraph'
shape_properties._vertical_position = 50
shape_properties._horizontal_position = 150
shape_properties._fill_color = Color(0, 206, 209)
shape_properties._rotation = 45
shape_properties._stroke_weight = 2
shape_properties._stroke_color = Color(173, 255, 47)
shape_properties._text_wrapping_type = 'Both'
shape_properties._text_wrapping_style = 'InFrontOfText'
shape_properties._z_order = 1
extra = {'index_in_paragraph': 0, 'folder': "input", 'dest_file_path': 'output/AddShape.docx'}
result = api.add_shape(file_name, paragraph_path, shape_properties, **extra)