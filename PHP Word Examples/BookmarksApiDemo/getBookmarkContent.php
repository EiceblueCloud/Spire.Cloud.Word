<?php

use Spire\Cloud\Word\Sdk\Client\Api\BookmarksApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new BookmarksApi($configuration);

$name = "Bookmark.docx";
$bookmark_name = 'Test';
$folder = "input";
$storage = null;
$password = null;
$result = $apiInstance->getBookmarkContent(
    $name,
    $bookmark_name,
    $folder,
    $storage,
    $password
);