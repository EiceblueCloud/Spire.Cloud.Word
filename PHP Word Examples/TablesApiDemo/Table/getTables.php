<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName = "Table.docx";
$index = 0;
$node_path = 'Section/0/Body/0';
$folder = 'input';
$storage = null;
$password = null;
$result = $apiInstance->getTables($fileName,$folder,$storage,$password,$node_path);