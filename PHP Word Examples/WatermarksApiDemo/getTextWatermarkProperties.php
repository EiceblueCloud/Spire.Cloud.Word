<?php

use Spire\Cloud\Word\Sdk\Client\Api\WatermarksApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new WatermarksApi($configuration);

$name = "TextWatermark.doc";
$folder = "input";
$storage = null;
$password = null;
$result = $apiInstance->getTextWatermarkProperties($name, $folder, $storage, $password);