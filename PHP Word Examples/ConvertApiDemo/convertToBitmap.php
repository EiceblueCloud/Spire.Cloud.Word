<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ConvertApi($configuration);

$name = "ConvertToBitmap.docx";
$image_format = "jpeg"; //Available image format: jpeg, bmp, png
$folder="input";
$password = null;
$storage = null;
$start_page = null;
$page_count = null;
$package_into_zip = true;
$dest_folder = "output/ConvertToBitmap_jpeg/";
$apiInstance->convertToBitmap(
    $name,
    $image_format,
    $dest_folder,
    $password,
    $folder,
    $storage,
    $start_page,
    $page_count,
    $package_into_zip
);