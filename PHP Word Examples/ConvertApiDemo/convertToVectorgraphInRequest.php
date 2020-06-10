<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ConvertApi($configuration);

$inputFile = "D:/data/ConvertToVectorgraphInRequest.docx";
$image_type = "wmf"; //Available type: wmf, svg
$password = null;
$start_page = null;
$page_count = null;
 $result = $apiInstance->convertToVectorgraphInRequest(
     $inputFile,
     $image_type,
     $password,
     $start_page,
     $page_count
 );