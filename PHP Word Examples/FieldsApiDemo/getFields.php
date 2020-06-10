<?php

use Spire\Cloud\Word\Sdk\Client\Api\FieldsApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new FieldsApi($configuration);

$name = "GetField.docx";
$folder = "input";
$storage = null;
$password = null;
$paragraphPath = null;
$result = $apiInstance->getFields($fileName, $folder, $storage, $password,$paragraphPath);