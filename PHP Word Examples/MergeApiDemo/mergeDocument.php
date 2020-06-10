<?php

use \Spire\Cloud\Word\Sdk\Client\Api\MergeApi;
use \Spire\Cloud\Word\Sdk\Client\Configuration;
use \Spire\Cloud\Word\Sdk\Client\Model\MergingFile;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
var_dump($configuration);
$apiInstance = new MergeApi($configuration);

$name = "sample1.docx";
$folder = "input";
$storage = null;
$password = null;
$dest_file_path = "output/mergeDocuments.docx";
$files = array(
    new MergingFile(array(
        'path' => 'input/sample2.docx',
        'password'=>'123',
        'storage'=>null
    )),
     new MergingFile(array(
         'path' => 'input/sample3.docx',
         'password'=>null,
         'storage'=>null
     ))
);
$apiInstance->mergeDocument($name, $files,  $dest_file_path, $folder, $storage, $password);