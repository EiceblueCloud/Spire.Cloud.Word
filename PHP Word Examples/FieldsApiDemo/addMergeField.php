<?php

use Spire\Cloud\Word\Sdk\Client\Api\FieldsApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new FieldsApi($configuration);

$name = "AddMergeField.docx";
$field_name = 'test_name';
$paragraph_path = 'Section/0/Body/0/Paragraph/0';
$folder = "input";
$storage = null;
$index_in_paragraph = 1;
$field_code = null;
$password = null;
$dest_file_path = "output/AddMergeField.docx";;
$apiInstance->addMergeField($name, $paragraph_path, $field_name, $dest_file_path, $folder, $storage, $password, $index_in_paragraph, $field_code);