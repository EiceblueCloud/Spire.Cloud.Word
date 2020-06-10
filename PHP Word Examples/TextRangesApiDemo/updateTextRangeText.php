<?php

use Spire\Cloud\Word\Sdk\Client\Api\TextRangesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TextRangesApi($configuration);

$fileName = "Template.docx";
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$index = 0;
$text_range = 'E-iceblue test textRange';
$folder = "input";
$storage = null;
$password = null;
$dest_file_path = "TextRange/UpdateTextRangeText_1.docx";
$apiInstance->updateTextRangeText($fileName, $paragraph_path, $index, $text_range, $dest_file_path, $folder, $storage, $password);