<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName="DeleteTable_1_Temp2.docx";
$node_path1 = 'Section/0/Body/0';
$index = 1;
$dest_file_path = "Tables/DeleteTable_1.docx";
$folder = 'input';
$storage = null;
$password = null;
$apiInstance->deleteTable($fileName,$node_path,$index, $dest_file_path,$folder,$storage, $password);