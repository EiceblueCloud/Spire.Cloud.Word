<?php

use Spire\Cloud\Word\Sdk\Client\Api\TextRangesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TextRangesApi($configuration);

$fileName='GetTextRangeFormat_1.docx';
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$index = 0;
$folder="TextRange";
$storage = null;
$password = null;
$result = $apiInstance->getTextRangeFormat($fileName, $paragraph_path, $index, $folder, $storage, $password);