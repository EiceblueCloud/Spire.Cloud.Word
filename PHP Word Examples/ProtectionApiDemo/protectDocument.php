<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\ProtectionApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ProtectionApi($configuration);

$fileName='ProtectionTemp.docx';
$protection_type = "AllowOnlyReading"; //AllowOnlyComments,AllowOnlyFormFields,AllowOnlyRevisions,NoProtection
$folder ='input';
$storage = null;
$doc_password = null;
$protection_pwd = "123456";
$dest_file_path = "/Protection/ProtectDocument_AllowOnlyReading.docx";
$apiInstance->protectDocument(
    $fileName,
    $protection_type,
    $dest_file_path,
    $folder,
    $storage,
    $doc_password,
    $protection_pwd
);