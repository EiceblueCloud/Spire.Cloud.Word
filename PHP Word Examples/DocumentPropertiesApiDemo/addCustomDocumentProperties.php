<?php

use Spire\Cloud\Word\Sdk\Client\Api\DocumentPropertiesApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\CustomDocumentProperty;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new DocumentPropertiesApi($configuration);

$name = "DocumentProperties.docx";
$properties = array(
    new CustomDocumentProperty(array('name' => 'Keywords', 'value' => 'Set document properties.')),
    new CustomDocumentProperty(array('name' => 'Author', 'value' => 'eiceblue')),
    new CustomDocumentProperty(array('name' => 'Company', 'value' => '冰蓝')),
    new CustomDocumentProperty(array('name' => 'LastSavedBy', 'value' => '123456@iCloud.com')),
    new CustomDocumentProperty(array('name' => 'SharedDoc', 'value' => 'true')),
    new CustomDocumentProperty(array('name' => 'Date', 'value' => '2019/10/30'))
);
$folder = "input";
$storage = null;
$password = null;
$dest_file_path = "output/AddCustomDocumentProperties.docx";
$apiInstance->addCustomDocumentProperties($name, $properties, $password, $folder, $storage, $dest_file_path);