<?php

use Spire\Cloud\Word\Sdk\Client\Api\BackgroundApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new BackgroundApi($configuration);

$name = "setBackgroundImageWithImgFile.docx";
$input_image = "D:/data/Background.png";
$password = null;
$folder = "input";
$storage = null;
$dest_file_path = "output/setBackgroundImageWithImgFile.docx";
$result=$apiInstance->setBackgroundImageInRequest($name, $input_image,$dest_file_path, $folder, $storage, $password);