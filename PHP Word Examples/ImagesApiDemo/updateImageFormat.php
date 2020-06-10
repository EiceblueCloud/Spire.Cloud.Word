<?php

use Spire\Cloud\Word\Sdk\Client\Api\ImagesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ImagesApi($configuration);

$name = "Image.docx";
$paragraph_path = "Section/0/Body/0/Paragraph/1";
$index = 0;
$format  = new ImageFormat(
    array(
        'width' => 400,
        "height" => 400,
        "rotation" => 20,
        "horizontal_position" => 50,
        "vertical_position" => 50));
$password = null;
$folder = "input";
$storage = null;
$dest_file_path = "output/UpdateImageFormat.docx";
$result = $apiInstance->updateImageFormat(
    $name,
    $paragraph_path,
    $index,
    $dest_file_path,
    $format,
    $password,
    $folder,
    $storage
);