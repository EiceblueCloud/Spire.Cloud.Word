<?php

use \Spire\Cloud\Word\Sdk\Client\Api\ParagraphsApi;
use \Spire\Cloud\Word\Sdk\Client\Configuration;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ParagraphsApi($configuration);
$fileName='sample.docx';
$folder = 'input';
$storage = null;
$password = null;
$node_path = null; //or $node_path = 'Section/0/Body/0';
$result = $apiInstance->getParagraphs(
    $fileName,
    $folder,
    $storage,
    $password,
    $node_path
);
print_r($result);