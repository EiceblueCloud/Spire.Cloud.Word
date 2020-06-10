<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ConvertApi($configuration);

$name = "convert.docx";
$folder = "input";
$storage = null;
$format = 'postScript'; //Available format: pdf, pcl, dot, dotx, dotm, docm, odt, wordxml, wordml, xps, docx, doc, rtf, epub, xps, html
$password = null;
$dest_file_path = "output/convert.ps";
$apiInstance->convert($name, $format,$dest_file_path, $password, $folder, $storage);