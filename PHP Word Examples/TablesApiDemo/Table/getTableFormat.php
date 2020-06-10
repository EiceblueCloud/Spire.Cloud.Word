<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName = "GetTableFormat_1.docx";
$node_path = 'Section/0/Body/0';
$index = 1;
$folder = 'input';
$storage = null;
$password = null;
$result = $apiInstance->getTableFormat($fileName,$node_path, $index,$folder,$storage,$password);