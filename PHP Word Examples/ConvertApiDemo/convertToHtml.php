<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ConvertApi($configuration);

$name = "ConvertToHtml.docx";
$folder = "input";
$format = 'html';
$password = null;
$dest_file_path =  "output/ConvertToHtml/";
$result=$apiInstance->convertToHtml($name,$dest_file_path, $password, $folder, $storage);