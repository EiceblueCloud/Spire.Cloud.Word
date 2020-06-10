<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ConvertApi($configuration);

$inputFile = "D:/data/convertDocument.docx";
$format = 'pdf'; //Available format: pdf, pcl, dot, dotx, dotm, docm, odt, wordxml, wordml, xps, docx, doc, rtf, epub, xps, html
$password = null;
$result = $apiInstance->convertInRequest($inputFile, $format, $password);