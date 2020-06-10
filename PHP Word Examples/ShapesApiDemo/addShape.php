<?php

use \Spire\Cloud\Word\Sdk\Client\Configuration;
use \Spire\Cloud\Word\Sdk\Client\Api\ShapesApi;
use \Spire\Cloud\Word\Sdk\Client\Model\ShapeFormat;
use \Spire\Cloud\Word\Sdk\Client\Model\Color;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ShapesApi($configuration);

$fileName = "test.docx";
$paragraph_path = 'Section/0/Body/0/Paragraph/2';
$shape_properties = new ShapeFormat(array(
    'width' => 40,
    'height' => 40,
    'shape_type' => ShapeFormat::SHAPE_TYPE_RECTANGLE,
    'horizontal_origin'=> ShapeFormat::HORIZONTAL_ORIGIN_PAGE,
    'vertical_origin'=>ShapeFormat::VERTICAL_ORIGIN_PARAGRAPH,
    'vertical_position'=>50,
    'horizontal_position'=>150,
    'fill_color' => new Color(array('red' => 0, 'green' => 206, 'blue' => 209)),
    'rotation'=> 45,
    'stroke_weight'=>2,
    'stroke_color'=>new Color(array('red' => 173, 'green' => 255, 'blue' => 47)),
    'text_wrapping_type'=>ShapeFormat::TEXT_WRAPPING_TYPE_BOTH,
    'text_wrapping_style'=>ShapeFormat::TEXT_WRAPPING_STYLE_IN_FRONT_OF_TEXT,
    'z_order' => 1
));
$index_in_paragraph = 0;
$folder = 'input';
$storage = null;
$password = null;
$dest_file_path = "Shapes/AddShape_1.docx";
$apiInstance->addShape($fileName, $paragraph_path, $shape_properties, $dest_file_path, $folder, $storage, $index_in_paragraph, $password);