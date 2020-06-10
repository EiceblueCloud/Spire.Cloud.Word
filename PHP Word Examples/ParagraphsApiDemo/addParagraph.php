<?php

use \Spire\Cloud\Word\Sdk\Client\Api\ParagraphsApi;
use \Spire\Cloud\Word\Sdk\Client\Configuration;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ParagraphsApi($configuration);
$fileName='AddParagraph_1_Temp.docx';
$node_path = 'Section/0/Body/0';
$index_of_paragraph = 0;
$folder = 'input';
$storage = null;
$text = "Welcome to use Spire.Cloud.Word!";
$password = null;
$dest_file_path = "Paragraphs/AddParagraph_1_Temp.docx";
$apiInstance->addParagraph($fileName, $node_path, $dest_file_path, $folder, $storage, $index_of_paragraph, $password, $text);
