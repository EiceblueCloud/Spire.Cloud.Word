<?php

use Spire\Cloud\Word\Sdk\Client\Api\EncryptApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new EncryptApi($configuration);

$fileName = "EncryptDocument.docx";
$folder = "input";
$storage = null;
$old_password = null;
$new_password = '123';
$dest_file_path = "output/EncryptDocument.docx";
$apiInstance->encryptDocument($fileName, $dest_file_path, $folder, $storage, $old_password, $new_password);