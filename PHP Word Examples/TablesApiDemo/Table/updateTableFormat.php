<?php

use Spire\Cloud\Word\Sdk\Client\Api\TablesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\Border;
use Spire\Cloud\Word\Sdk\Client\Model\Borders;
use Spire\Cloud\Word\Sdk\Client\Model\Color;
use Spire\Cloud\Word\Sdk\Client\Model\TableFormat;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TablesApi($configuration);

$fileName = "UpdateTableFormat_1_Temp2.docx";
$node_path = 'Section/0/Body/0';
$index = 0;
$properties = new TableFormat(array(
    'bidi'=>true,
    'borders'=>new Borders(array(
        'top_border'=>new Border(array(
            'border_type'=>Border::BORDER_TYPE_DOT,
            'color'=>new Color(array('red' => 255, 'green' => 25, 'blue' => 1)),
            'line_width'=>3
        ))
    ))
));
$folder = 'input';
$storage = null;
$password = null;
$dest_file_path = "Tables/UpdateTableFormat_1.docx";
$apiInstance->updateTableFormat($fileName, $node_path,$index,$properties,$dest_file_path,$folder,$storage,$password);