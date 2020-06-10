<?php

use Spire\Cloud\Word\Sdk\Client\Api\MailMergeApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\MailMergeData;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new MailMergeApi($configuration);

$name = "MailMerge.docx";
$folder = "input";
$storage = null;
$password = null;
$dest_file_path = "output/MailMerge.docx";
$data = array(
    new MailMergeData(array('name' => 'Contact Name', 'value' => 'E-iceblue')),
    new MailMergeData(array('name' => 'Fax', 'value' => '123456789')),
    new MailMergeData(array('name' => 'Date', 'value' => '2019-10-16'))
);
$result = $apiInstance->mailMerge($name, $dest_file_path, $data, $folder, $storage, $password);