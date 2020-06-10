<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$filename="DeleteTableCell_1_Temp2.docx";
$table_row_path = 'Section/0/Body/0/Table/0/TableRow/0';
$index = 0;
$dest_file_path = "Tables/DeleteTableCell_1.docx";
$folder="input";
$storage=null;
$password=null;
$result = $apiInstance->deleteTableCell($filename, $table_row_path, $index, $dest_file_path, $folder, $storage, $password);