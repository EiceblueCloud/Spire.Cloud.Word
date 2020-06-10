<?php

use Spire\Cloud\Word\Sdk\Client\Api\FieldsApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new FieldsApi($configuration);

$name = "UpdateField.docx";
$folder = "input";
$storage = null;
$password = null;
$dest_file_path = "output/UpdateField.docx";
$apiInstance->updateField($name, $dest_file_path, $folder, $storage, $password);