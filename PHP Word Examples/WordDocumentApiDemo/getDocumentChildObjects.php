<?php

use Spire\Cloud\Word\Sdk\Client\Api\WordDocumentApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new WordDocumentApi($configuration);

$name = "Template.docx";
$folder = "DocDocument";
$storage = null;
$password = null;
$result = $apiInstance->getDocumentChildObjects($name,$folder, $storage, $password);