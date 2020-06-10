<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ConvertApi($configuration);

$inputFile = "D:/data/convertToBitmapInRequest.docx";
$image_format = "jpeg"; //Available image format: jpeg, bmp, png
$password = null;
$start_page = null;
$page_count = null;
$result = $apiInstance->convertToBitmapInRequest(
    $inputFile,
    $image_format,
    $password,
    $start_page,
    $page_count
);