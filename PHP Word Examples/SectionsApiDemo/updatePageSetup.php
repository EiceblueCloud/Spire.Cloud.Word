<?php

use Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Api\SectionsApi;
use Spire\Cloud\Word\Sdk\Client\Model\LineNumber;
use Spire\Cloud\Word\Sdk\Client\Model\Margin;
use Spire\Cloud\Word\Sdk\Client\Model\PageSetup;

$appId = "your id";
$appKey = "your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId, $appKey, $baseUrl);
$apiInstance = new SectionsApi($configuration);

$name = "PageSetup.docx";
$folder = 'input';
$storage = null;
$section_index = 0;
$page_setup = new PageSetup(array(
    'page_width' => 400,
    'page_height' => 500,
    'linenumber' => new LineNumber(array(
        'start_value' => 1,
        'step' => 2,
        'distance_from_text' => 20,
        'restart_mode' => LineNumber::RESTART_MODE_CONTINUOUS //RESTART_MODE_RESTART_SECTION, RESTART_MODE_RESTART_PAGE
    )),
    'page_margin' => new Margin(array(
        'top' => 20,
        'bottom' => 20,
        'left' => 20,
        'right' => 20
    )),
    'orientation' => PageSetup::ORIENTATION_LANDSCAPE //ORIENTATION_PORTRAIT
));
$password = null;
$dest_file_path = "Sections/UpdatePageSetup_1.docx";
$apiInstance->updatePageSetup($name, $section_index, $page_setup, $dest_file_path, $folder, $storage, $password);