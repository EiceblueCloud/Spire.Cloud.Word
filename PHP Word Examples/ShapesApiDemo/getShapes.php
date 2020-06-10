<?php

use \Spire\Cloud\Word\Sdk\Client\Configuration;
use \Spire\Cloud\Word\Sdk\Client\Api\ShapesApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ShapesApi($configuration);

$fileName = "Shape.docx";
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$folder ="input";
$storage = null;
$password = null;
$result = $apiInstance->getShapes($fileName,  $folder, $storage, $password,$paragraph_path);