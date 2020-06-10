<?php

use Spire\Cloud\Word\Sdk\Client\Api\BookmarksApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new BookmarksApi($configuration);

$name = "Bookmarks.docx";
$folder = "input";
$storage = null;
$password = null;
$result = $apiInstance->getBookmarks(
    $name,
    $folder,
    $storage,
    $password
);