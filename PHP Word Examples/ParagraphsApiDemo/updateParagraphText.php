<?php

use \Spire\Cloud\Word\Sdk\Client\Configuration;
use \Spire\Cloud\Word\Sdk\Client\Api\ParagraphsApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ParagraphsApi($configuration);

$filename='UpdateParagraphText_1_Temp2.docx';
$node_path = 'Section/0/Body/0';
$index = 1;
$text = "Test UpdateParagraphText ";
$folder='input';
$dest_file_path = "Paragraphs/UpdateParagraphText_1.docx";
$storage = null;
$password = null;
$apiInstance->updateParagraphText($filename, $node_path, $index, $text, $dest_file_path, $folder, $storage, $password);