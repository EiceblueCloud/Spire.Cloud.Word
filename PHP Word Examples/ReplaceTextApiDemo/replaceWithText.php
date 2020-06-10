<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\ReplaceTextApi;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ReplaceTextApi($configuration);

$fileName = "ReplaceText.docx";
$old_value = '#test';
$new_value = "E-iceblue";
$match_case = false;
$match_whole_word = null;
$replace_first = null;
$password = null;
$folder = "input";
$storage = null;
$dest_file_path = "/ReplaceText/ReplaceWithText_false.docx";
$apiInstance->replaceWithText(
    $fileName,
    $old_value,
    $new_value,
    $dest_file_path,
    $password,
    $folder,
    $storage,
    $match_case,
    $match_whole_word,
    $replace_first
);