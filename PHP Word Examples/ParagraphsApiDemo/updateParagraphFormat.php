<?php

use \Spire\Cloud\Word\Sdk\Client\Configuration;
use Spire\Cloud\Word\Sdk\Client\Model\Border;
use Spire\Cloud\Word\Sdk\Client\Model\Borders;
use \Spire\Cloud\Word\Sdk\Client\Api\ParagraphsApi;
use \Spire\Cloud\Word\Sdk\Client\Model\Color;
use \Spire\Cloud\Word\Sdk\Client\Model\ParagraphFormat;

$appId="your id";
$appKey="your key";
$baseUrl = "https://api.e-iceblue.cn";
$configuration = new Configuration($appId,$appKey,$baseUrl);
$apiInstance = new ParagraphsApi($configuration);

$filename="UpdateParagraphFormat_1_Temp2.docx";
$folder="input";
$node_path = 'Section/0/Body/0';
$index = 0;
$dest_file_path = "Paragraphs/UpdateParagraphFormat_1.docx";
$format = new ParagraphFormat(array(
    'horizontal_alignment'=>ParagraphFormat::HORIZONTAL_ALIGNMENT_DISTRIBUTE,
    'left_or_inner_indent' => 20,
    'right_or_outside_indent' =>10,
    'mirror_indents' =>false,
    'first_line_indent' => 30,
    'background_color' => new Color(array('red' => 100, 'green' => 100, 'blue' => 100)),
    'before_spacing'=>40,
    'after_spacing'=>40,
    'before_auto_spacing'=>false,
    'after_auto_spacing'=>false,
    'line_space'=>50,
    'line_spacing_rule'=>ParagraphFormat::LINE_SPACING_RULE_EXACTLY,
    'word_wrap'=>true,
    'borders'=>new Borders(array(
        'top_border'=>new Border(array(
            'border_type'=>Border::BORDER_TYPE_DOUBLE
        ))
    ))
));
$storage = null;
$password = null;
$apiInstance->updateParagraphFormat($filename, $node_path, $index, $format, $dest_file_path, $folder, $storage, $password);