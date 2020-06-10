<?php

use Spire\Cloud\Word\Sdk\Client\Api\TextRangesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TextRangesApi($configuration);

$fileName = "Template.docx";
$paragraph_Path = "Section/0/Body/0/Paragraph/0";
$folder = "input";
$storage = null;
$password = null;
$index = 0;
$result = $apiInstance->getTextRangeText($fileName, $paragraph_Path, $index, $folder, $storage, $password);