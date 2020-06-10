<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\TableRowFormat;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName="UpdateTableRowFormat_1_true_Temp.docx";
$table_path = 'Section/0/Body/0/Table/0';
$index = 55;
$format = new TableRowFormat(array(
    'height' => 100,
    'height_type'=>TableRowFormat::HEIGHT_TYPE_EXACTLY,  //HEIGHT_TYPE_AT_LEAST, HEIGHT_TYPE_AUTO
    'break_across_pages' => true,
    'header' => true
));
$folder="Tables";
$dest_file_path = "Tables/UpdateTableRowFormat_1_true.docx";
$storage = null;
$password = null;
$apiInstance->updateTableRowFormat($fileName,$table_path,$index,$format,$dest_file_path,$folder,$storage,$password);