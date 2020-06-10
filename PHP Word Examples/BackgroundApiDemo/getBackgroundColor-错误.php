<?php

use Spire\Cloud\Word\Sdk\Client\Api\BackgroundApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new BackgroundApi($configuration);

$name = "getBackgroudColor.docx";
$color = new Color();
$color->setRed(127);
$color->setGreen(255);
$color->setBlue(170);
$password = null;
$folder = "input";
$storage = null;
$dest_file_path = "output/getBackgroudColor.docx";
$result=$apiInstance->setBackgroundColor($name, $color,$dest_file_path, $folder, $storage, $password);