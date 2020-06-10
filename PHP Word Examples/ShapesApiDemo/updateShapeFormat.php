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

$fileName = "Shape.docx";
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$index = 0;
$shape_properties = new ShapeFormat(array(
    'width' => 50,
    'height' => 50,
    'shape_type' => ShapeFormat::SHAPE_TYPE_OCTAGON,
    'horizontal_origin'=> ShapeFormat::HORIZONTAL_ORIGIN_LEFT_MARGIN_AREA,
    'vertical_origin'=>ShapeFormat::VERTICAL_ORIGIN_PARAGRAPH,
    'vertical_position'=>80,
    'horizontal_position'=>80,
    'fill_color' => new Color(array('red' => 100, 'green' => 100, 'blue' => 100)),
    'rotation'=> 0,
    'stroke_weight'=>2,
    'stroke_color'=>new Color(array('red' => 0, 'green' => 206, 'blue' => 209)),
    'text_wrapping_type'=>ShapeFormat::TEXT_WRAPPING_TYPE_BOTH,
    'text_wrapping_style'=>ShapeFormat::TEXT_WRAPPING_STYLE_IN_FRONT_OF_TEXT,
    'z_order' => 1
));
$folder ='input';
$storage = null;
$password = null;
$dest_file_path =  "Shapes/UpdateShapeFormat_1.docx";
$apiInstance->updateShapeFormat($fileName, $paragraph_path, $index, $shape_properties, $dest_file_path, $folder, $storage, $password);