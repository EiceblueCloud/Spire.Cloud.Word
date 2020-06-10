<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$name = "addTableCell.docx";
$table_row_path = 'Section/0/Body/0/Table/7/TableRow/5';
$index_of_table_cell = 2;
$folder = "input";
$storage = null;
$password = null;
$dest_file_path = "output/addTableCell_output.docx";
$result = $apiInstance->addTableCell($name, $table_row_path, $dest_file_path, $folder, $storage, $index_of_table_cell, $password);