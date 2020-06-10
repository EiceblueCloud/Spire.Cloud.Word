<?php

use Spire\Cloud\Word\Sdk\Client\Api\BackgroundApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new BackgroundApi($configuration);

$name = "deleteBackground.docx";
$password = null;
$folder = "input";
$storage = null;
$dest_file_path = "output/deleteBackground.docx";
$result=$apiInstance->deleteBackground($name,$dest_file_path, $password, $folder, $storage);