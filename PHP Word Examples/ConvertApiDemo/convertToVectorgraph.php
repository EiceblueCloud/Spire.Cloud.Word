<?php

use Spire\Cloud\Word\Sdk\Client\Api\ConvertApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new ConvertApi($configuration);

$name = "ConvertToVectorgraph.docx";
$image_type = "wmf"; //Available type: wmf, svg
$folder = "input";
$password = null;
$start_page = null;
$page_count = null;
$storage = null;
$dest_folder = "output/ConvertToVectorgraph_WMF/";
$apiInstance->convertToVectorgraph(
    $name,
    $image_type,
    $dest_folder,
    $password,
    $folder,
    $storage,
    $start_page,
    $page_count
);