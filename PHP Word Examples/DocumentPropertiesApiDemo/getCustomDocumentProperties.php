<?php

use Spire\Cloud\Word\Sdk\Client\Api\DocumentPropertiesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new DocumentPropertiesApi($configuration);

$fileName = "CustomDocumentProperties.docx";
$folder = "input";
$storage = null;
$password = null;
$result = $apiInstance->getCustomDocumentProperties($fileName, $password,$folder, $storage);