<?php

use Spire\Cloud\Word\Sdk\Client\Api\BackgroundApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new BackgroundApi($configuration);

$name = "setBackgroundImage.docx";
$image_path = "input/Background.png";
$password = null;
$folder = "input";
$storage = null;
$dest_file_path = "output/setBackgroundImage.docx";
$result=$apiInstance->setBackgroundImage($name, $image_path,$dest_file_path, $folder, $storage, $password);