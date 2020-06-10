<?php

use \Spire\Cloud\Word\Sdk\Client\Api\ParagraphsApi;
use \Spire\Cloud\Word\Sdk\Client\Configuration;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ParagraphsApi($configuration);
$fileName = "sample1.docx";
$node_path = 'Section/0/Body/0';
$index = 0;
$folder = "input";
$storage = null;
$password = null;
$result = $apiInstance->getParagraphChildObjects($fileName, $node_path, $index, $folder, $storage, $password);
print_r($result);