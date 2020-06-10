<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName="AddTableRow_1_Temp.docx";
$table_path = 'Section/0/Body/0/Table/0';
$index_of_table_row = 0;
$cells_count = 4;
$dest_file_path = "Tables/AddTableRow_1.docx";
$folder="Tables";
$password =null;
$storage = null;
$apiInstance->addTableRow($fileName, $table_path, $dest_file_path,$folder , $storage, $index_of_table_row, $cells_count, $password);