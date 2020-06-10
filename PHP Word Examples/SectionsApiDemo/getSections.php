<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\SectionsApi;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey, $baseUrl);
$apiInstance = new SectionsApi($configuration);

$name = "PageSetup.docx";
$folder = "input";
$storage =null;
$password =null;
$result = $apiInstance->getSections($name, $folder, $storage, $password);