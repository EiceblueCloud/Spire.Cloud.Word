<?php

use Spire\Cloud\Word\Sdk\Client\Api\EncryptApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new EncryptApi($configuration);

$filename = "D:/data/Template.docx";
$old_password = null;
$new_password = '123456';
$result = $apiInstance->encryptDocumentInRequest($filename, $old_password, $new_password);