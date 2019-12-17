import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.*;
import spire.cloud.word.sdk.client.model.*;

public class TablesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
 
    public static void addTable() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="addTable.docx";
        String nodePath = "sections/0";
        Integer rowsCount = 3;
        Integer columnsCount = 3;
        String folder = "input";
        String storage = null;
        Integer indexOfTable = 0;
        String password = null;
        String destFilePath ="output/addTable_output.docx";
        api.addTable(name, nodePath, rowsCount, columnsCount, folder, storage, indexOfTable, password, destFilePath);
    }
    public static void addTableCell() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="addTableCell.docx";
        String tableRowPath = "sections/0/tables/0/rows/0";
        String folder = "input";
        String storage = null;
        Integer indexOfTableCell = 0;
        String password = null;
        String destFilePath ="output/addTableCell_output.docx";
        api.addTableCell(name, tableRowPath, folder, storage, indexOfTableCell, password, destFilePath);
    }
    public static void addTableRow() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="addTableRow.docx";
        String tablePath = "sections/0/tables/0";
        String folder = "input";
        String storage = null;
        Integer indexOfTableRow = 0;
        Integer cellsCount = 2;
        String password = null;
        String destFilePath ="output/addTableRow_output.docx";
        api.addTableRow(name, tablePath, folder, storage, indexOfTableRow, cellsCount, password, destFilePath);
    }
    public static void deleteTable() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="deleteTable.docx";
        String nodePath = "sections/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/deleteTable_output.docx";
        api.deleteTable(name, nodePath, index, folder, storage, password, destFilePath);
    }
    public static void deleteTableCell() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="deleteTableCell.docx";
        String tableRowPath = "sections/0/tables/0/rows/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/deleteTableCell_output.docx";
        api.deleteTableCell(name, tableRowPath, index, folder, storage, password, destFilePath);
    }
    public static void deleteTableRow() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="deleteTableRow.docx";
        String tablePath = "sections/0/tables/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/deleteTableRow_output.docx";
        api.deleteTableRow(name, tablePath, index, folder, storage, password, destFilePath);
    }
    public static void getTableCellProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="getTableCellProperties.docx";
        String tableRowPath = "sections/0/tables/0/rows/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TableCellFormat response = api.getTableCellProperties(name, tableRowPath, index, folder, storage, password);
    }
    public static void getTableProperties() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="getTableProperties.docx";
        String nodePath = "sections/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TableFormat response = api.getTableProperties(name, nodePath, index, folder, storage, password);
    }
    public static void getTableRowFormat() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="getTableRowFormat.docx";
        String tablePath = "sections/0/tables/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TableRowFormat response = api.getTableRowFormat(name, tablePath, index, folder, storage, password);
    }
    public static void updateTableCellFormat() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name="updateTableCellFormat.docx";
        String tableRowPath = "sections/0/tables/0/rows/0";
        Integer index = 0;
        TableCellFormat format = new TableCellFormat();
        Color color=new Color();
        color.red(100);
        color.green(100);
        color.blue(100);
        format.backgroundColor(color);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/updateTableCellFormat_output.docx";
        api.updateTableCellFormat(name, tableRowPath, index, format, folder, storage, password, destFilePath);
    }
    public static void updateTableFormat() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="updateTableFormat.docx";
        String nodePath = "sections/0";
        Integer index = 0;
        TableFormat properties = new TableFormat();
        properties.bidi(false);
        Borders borsers = new Borders();
        Border borser = new Border();
        borsers.setTopBorder(borser);
        properties.setBorders(borsers);
        borsers.getTopBorder().setBorderType(Border.BorderTypeEnum.DOT);
        Color color=new Color();
        color.red(255);
        color.green(25);
        color.blue(1);
        borsers.getTopBorder().setColor(color);
        borsers.getTopBorder().setLineWidth(3f);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/updateTableFormat_output.docx";
        api.updateTableFormat(name, nodePath, index, properties, folder, storage, password, destFilePath);
    }
    public static void updateTableRowFormat() throws ApiException {
        Configuration wordConfiguration = new Configuration(appId, appKey);
        TablesApi api = new TablesApi(wordConfiguration);
        String name ="updateTableRowFormat.docx";
        String tablePath = "sections/0/tables/0";
        Integer index = 0;
        TableRowFormat format = new TableRowFormat();
        format.breakAcrossPages(true);
        format.height(50.0f);
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath ="output/updateTableRowFormat_output.docx";
        api.updateTableRowFormat(name, tablePath, index, format, folder, storage, password, destFilePath);
    }
}
