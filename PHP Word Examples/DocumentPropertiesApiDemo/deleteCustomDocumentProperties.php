<?php

use Spire\Cloud\Word\Sdk\Client\Api\DocumentPropertiesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new DocumentPropertiesApi($configuration);

$fileName = "DocumentProperties.docx";
$propertie_name_1 = "Date";
$folder = "input";
$storage = null;
$password = null;
$dest_file_path = "output/DeleteCustomDocumentProperties.docx";
$apiInstance->deleteCustomDocumentProperties($fileName, $propertie_name_1, $dest_file_path,  $password,$folder, $storage);