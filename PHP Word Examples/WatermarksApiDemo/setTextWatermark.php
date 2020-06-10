<?php

use Spire\Cloud\Word\Sdk\Client\Api\WatermarksApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\Color;
use Spire\Cloud\Word\Sdk\Client\Model\Font;
use Spire\Cloud\Word\Sdk\Client\Model\TextWatermark;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new WatermarksApi($configuration);

$name = "Template.docx";
$folder = "input";
$storage = null;
$body = new TextWatermark(array(
    'text' => 'E-iceblue',
    'font' => new Font(array(
        'font_size' => 60,
        'font_name' => 'Cooper Black',
        'color' => new Color(array(
            'red' => 100,
            'blue' => 100,
            'green' => 100
        ))
    )),
    'layout'=>TextWatermark::LAYOUT_HORIZONTAL
));
$password = null;
$dest_file_path = "Watermark/SetTextWatermark_Horizontal.docx";
$apiInstance->setTextWatermark($name, $body, $dest_file_path,$folder, $storage, $password);