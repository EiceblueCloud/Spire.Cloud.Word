<?php

use Spire\Cloud\Word\Sdk\Client\Api\TextRangesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new TextRangesApi($configuration);

$fileName='AddTextRange_1.docx';
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$index_in_paragraph = 0;// null means text range will be added at the end of paragraph
$text_range = 'AddTextRange';
$folder="TextRange";
$storage = null;
$password = null;
$dest_file_path = "TextRange/AddTextRange_1.docx";
$apiInstance->addTextRange($fileName,$paragraph_path, $text_range,$dest_file_path,$folder,$storage,$index_in_paragraph, $password);