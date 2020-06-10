<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\ReplaceTextApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ReplaceTextApi($configuration);

$file ='D:/template.docx';
$regex =   @"\#\w+\b";
$new_value = 'E-iceblue';
$password = null;
$storage=null;
$apiInstance->replaceWithRegexInRequest(
    $file,
    $regex,
    $new_value,
    $password,
    $storage
);