<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\ReplaceTextApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ReplaceTextApi($configuration);

$fileName = "ReplaceText.docx";
$regex =  @"\#\w+\b";
$new_value = "E-iceblue";
$password = null;
$folder = 'input';
$storage = null;
$dest_file_path = "/ReplaceText/ReplaceWithRegex.docx";
$apiInstance->replaceWithRegex(
    $fileName,
    $regex,
    $new_value,
    $dest_file_path,
    $password,
    $folder,
    $storage
);