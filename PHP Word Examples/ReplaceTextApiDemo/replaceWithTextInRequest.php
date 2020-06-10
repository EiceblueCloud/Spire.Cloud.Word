<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\ReplaceTextApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ReplaceTextApi($configuration);

$input_file = "D:/ReplaceText.docx";
$old_value = '#test';
$new_value = "E-iceblue";
$password = null;
$match_case = false;
$match_whole_word = null;
$replace_first = null;
$result = $apiInstance->replaceWithTextInRequest(
    $input_file,
    $old_value,
    $new_value,
    $password,
    $match_case,
    $match_whole_word,
    $replace_first
);