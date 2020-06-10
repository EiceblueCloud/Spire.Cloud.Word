<?php

use \Spire\Cloud\Word\Sdk\Client\Configuration;
use \Spire\Cloud\Word\Sdk\Client\Api\ShapesApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ShapesApi($configuration);

$fileName = "AddShapes.docx";
$folder = "input";
$storage = null;
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$index = 1;
$password = null;
$dest_file_path =  "Shapes/DeleteShape_1.docx";
$apiInstance->deleteShape($fileName, $paragraph_path, $index, $dest_file_path, $folder, $storage, $password);