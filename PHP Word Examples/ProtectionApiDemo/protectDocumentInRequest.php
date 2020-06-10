<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\ProtectionApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ProtectionApi($configuration);

$input_file = "D:/input/test3.docx";
$protection_type = "AllowOnlyReading"; //AllowOnlyComments,AllowOnlyFormFields,AllowOnlyRevisions,NoProtection
$doc_password = null;
$protection_pwd = "123456";
$result = $apiInstance->protectDocumentInRequest(
        $input_file,
        $protection_type,
        $doc_password,
        $protection_pwd
);
print_r($result);