<?php

use Spire\Cloud\Word\Sdk\Client\Api\BookmarksApi;
use Spire\Cloud\Word\Sdk\Client\Configuration;

$appId = "your id";
$appKey = "your key";
$baseUrl="https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey,$baseUrl);
$apiInstance = new BookmarksApi($configuration);

$name = "Bookmark.docx";
$start_paragraph_path = "Section/0/Body/0/Paragraph/0";
$start_index_in_paragraph = 0;
$end_paragraph_path = "Section/0/Body/0/Paragraph/2";
$end_index_in_paragraph = 0;
$bookmark_name = 'Text_Bookmark';
$folder = "input";
$storage = null;
$password = null;
$dest_file_path ="output/AddBookmarkForText.docx";
$result = $apiInstance->addBookmark(
    $name,
    $start_paragraph_path,
    $start_index_in_paragraph,
    $end_paragraph_path,
    $end_index_in_paragraph,
    $bookmark_name,
    $dest_file_path,
    $folder,
    $storage,
    $password
);