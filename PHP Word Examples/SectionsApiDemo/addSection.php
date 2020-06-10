<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\SectionsApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new SectionsApi($configuration);

$name = "Template.docx";
$folder = 'input';
$storage = null;
$password = null;
$section_index = null;
$dest_file_path = "/Sections/AddSection_1.docx";
$apiInstance->addSection(
    $name,
    $dest_file_path,
    $folder,
    $storage,
    $password,
    $section_index
);