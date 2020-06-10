<?php

use \Spire\Cloud\Word\Sdk\Client\Api\ParagraphsApi;
use \Spire\Cloud\Word\Sdk\Client\Configuration;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ParagraphsApi($configuration);
$fileName='DeleteParagraph_2_Temp2.docx';
$node_path = 'Section/0/Body/0';
$index_of_paragraph = 1;
$folder = 'input';
$storage = null;
$password = null;
$dest_file_path = "Paragraphs/DeleteParagraph_3.docx";
$apiInstance->deleteParagraph($fileName, $node_path, $index_of_paragraph, $dest_file_path, $folder, $storage, $password);
