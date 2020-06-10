<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new DigitalSignatureApi($configuration);

$name = "Template.docx";
$pfx_file = "D:/data/Demo.pfx";
$secure_password = 'e-iceblue';
$folder = "input";
$storage = null;
$doc_password = null;
$dest_file_path = "output/AddDigitalSignature.docx";
$apiInstance->addDigitalSignature(
    $name,
    $pfx_file,
    $secure_password,
    $dest_file_path,
    $folder,
    $storage,
    $doc_password
);