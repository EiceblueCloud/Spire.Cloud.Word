<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName = "Table.docx";
$table_row_path = 'Section/0/Body/0/Table/0/TableRow/0';
$index = 0;
$folder ='input';
$storage = null;
$password = null;
$result = $apiInstance->getTableCellChildObjects($fileName, $table_row_path, $index, $folder, $storage, $password);