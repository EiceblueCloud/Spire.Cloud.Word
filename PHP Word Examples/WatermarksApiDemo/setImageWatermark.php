<?php

use Spire\Cloud\Word\Sdk\Client\Api\WatermarksApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new WatermarksApi($configuration);

$name = "Template.docx";
$image_path = "images/image.png";
$folder = "input";
$storage = null;
$scaling = 120;
$washout = true;
$password = null;
$dest_file_path =  "Watermark/SetImageWatermark_true.docx";
$apiInstance->setImageWatermark($name, $image_path, $dest_file_path, $folder, $storage, $scaling, $washout, $password);