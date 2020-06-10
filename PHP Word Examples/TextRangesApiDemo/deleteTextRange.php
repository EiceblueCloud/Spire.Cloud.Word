<?php

use Spire\Cloud\Word\Sdk\Client\Api\TextRangesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TextRangesApi($configuration);

$fileName=  "DeleteTextRange_1_Temp.docx";
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$index = 0;
$dest_file_path = "TextRange/DeleteTextRange_1.docx";
$folder="TextRange";
$storage = null;
$password = null;
$apiInstance->deleteTextRange($fileName, $paragraph_path, $index, $dest_file_path, $folder, $storage, $password);