<?php

use Spire\Cloud\Word\Sdk\Client\Api\TextRangesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\Color;
use Spire\Cloud\Word\Sdk\Client\Model\Font;
use Spire\Cloud\Word\Sdk\Client\Model\TextRangeFormat;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TextRangesApi($configuration);

$fileName="UpdateTextRangeFormat_1_Temp.docx";
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$index = 0;
$text_range = new TextRangeFormat(array(
    'font' => new Font(array(
        'font_size' => 30,
        'font_name' => 'Arial',
        'color' => new Color(array(
            'red' => 0,
            'blue' => 255,
            'green' => 255
        ))
    ))
));
$dest_file_path = "TextRange/UpdateTextRangeFormat_1.docx";
$folder = "input";
$storage = null;
$password = null;
$apiInstance->updateTextRangeFormat($fileName, $paragraph_path, $index, $text_range, $dest_file_path, $folder, $storage, $password);