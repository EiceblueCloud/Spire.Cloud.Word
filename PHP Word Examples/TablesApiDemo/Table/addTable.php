<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName = "AddTable_1.docx";
$node_path = 'Section/0/Body/0';
$rows_count = 6;
$columns_count = 6;
$index_of_table = 0;
$folder = 'input';
$storage = null;
$password = null;
$dest_file_path = "Tables/AddTable_1.docx";
$apiInstance->addTable($fileName, $node_path, $rows_count, $columns_count, $dest_file_path, $folder, $storage, $index_of_table, $password);