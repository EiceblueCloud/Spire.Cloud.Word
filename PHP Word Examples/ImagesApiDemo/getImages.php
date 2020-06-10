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
$folder = "input";
$storage = null;
$password = null;
$result = $apiInstance->getImages(
    $name,
    $password,
    $folder,
    $storage,
    $paragraph_path
);