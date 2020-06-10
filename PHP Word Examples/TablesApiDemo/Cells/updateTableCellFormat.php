<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\Color;
use Spire\Cloud\Word\Sdk\Client\Model\TableCellFormat;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName="UpdateTableCellFormat_1_100_Temp.docx";
$table_row_path = 'Section/0/Body/0/Table/0/TableRow/55';
$index = 5;
$format = new TableCellFormat(array(
    'width' => 100,
    'background_color' => new Color(array('red' => 100, 'blue' => 100, 'green' => 100))
));
$dest_file_path = "Tables/UpdateTableCellFormat_1_100.docx";
$folder="Tables";
$storage = null;
$password = null;
$result = $apiInstance->updateTableCellFormat($fileName, $table_row_path, $index, $format, $dest_file_path, $folder, $storage, $password);
