<?php

use Spire\Cloud\Word\Sdk\Client\Api\WordDocumentApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new WordDocumentApi($configuration);

$file_format = 'docx'; //doc, rtf, wordml, docm, dotx, dot, dotm
$name = 'CreateDocument';
$dest_folder = 'WordDocument';
$apiInstance->createDocument($file_format, $name, $dest_folder);