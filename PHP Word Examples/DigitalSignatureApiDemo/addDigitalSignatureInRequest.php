<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new DigitalSignatureApi($configuration);

$input_file ="D:/data/Template.docx";
$pfx_file = "D:/data/Demo.pfx";
$secure_password = 'e-iceblue';
$doc_password = null;
$result = $apiInstance->addDigitalSignatureInRequest(
    $input_file,
    $pfx_file,
    $secure_password,
    $doc_password
);