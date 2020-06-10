<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName="DeleteTableRow_1_Temp2.docx";
$table_path = 'Section/0/Body/0/Table/0';
$index = 0;
$dest_file_path = "Tables/DeleteTableRow_1.docx";
$folder="Tables";
$storage = null;
$password = null;
$apiInstance->deleteTableRow($fileName, $table_path, $index, $dest_file_path, $folder, $storage, $password);