<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName = "GetTableRowFormat_1.docx";
$table_path = 'Section/0/Body/0/Table/0';
$index = 0;
$folder="Tables";
$password =null;
$storage = null;
$result = $apiInstance->getTableRowFormat($fileName, $table_path,$index,$folder,$storage,$password);