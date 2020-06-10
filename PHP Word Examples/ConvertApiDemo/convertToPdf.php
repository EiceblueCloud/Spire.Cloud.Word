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
$password = null;
$dest_file_path = "output/ConvertToPdf.pdf";
$private_fonts = array(
    new PrivateFont(array(
        'name' => '黑体',
        'path' =>"DocDocument/simhei.ttf",
        'embed'=>true
    )),
    new PrivateFont(array(
        'name' => 'consola',
        'path' =>"DocDocument/consola.ttf",
        'embed'=>true
    ))
);
$apiInstance->convertToPdf($name, $dest_file_path, $password, $folder, $storage,$private_fonts);