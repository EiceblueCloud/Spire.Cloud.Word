import spire.cloud.word.sdk.client.*;
import spire.cloud.word.sdk.client.api.TablesApi;
import spire.cloud.word.sdk.client.model.*;
import java.math.BigDecimal;
import java.util.List;

public class TablesApiDemo {
    static String appId = "your id";
    static String appKey = "your key";
    static String baseUrl = "https://api.e-iceblue.cn";
    static Configuration wordConfiguration = new Configuration(appId, appKey, baseUrl);
    static TablesApi tablesApi = new TablesApi(wordConfiguration);

    public static void addTable() throws ApiException {
        String name = "tableSample.docx";
        String nodePath = "Section/0/Body/0";
        int indexOfTable = 0;
        Integer rowsCount = 6;
        Integer columnsCount = 6;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/AddTable_output.docx" ;
        tablesApi.addTable(name, nodePath, rowsCount, columnsCount, destFilePath, folder, storage, indexOfTable, password);
    }
    public static void addTableCell() throws ApiException {
        String name = "addTableCell.docx";
        String tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
        int indexOfTableCell = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/AddTableCell_output.docx";
        tablesApi.addTableCell(name, tableRowPath, destFilePath, folder, storage, indexOfTableCell, password);
    }
    public static void addTableRow() throws ApiException {
        String name = "addTableRow.docx";
        String tablePath = "Section/0/Body/0/Table/0";
        int indexOfTableRow = 0;
        String folder = "input";
        String storage = null;
        Integer cellsCount = 3;
        String password = null;
        String destFilePath = "output/AddTableRow_output.docx";
        tablesApi.addTableRow(name, tablePath, destFilePath,folder, storage, indexOfTableRow, cellsCount, password);
    }
    public static void deleteTable() throws ApiException {
        String name = "deleteTable.docx";
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/DeleteTable_output.docx";
        tablesApi.deleteTable(name, nodePath, index, destFilePath, folder, storage, password);
    }
    public static void deleteTableCell() throws ApiException {
        String name = "deleteTableCell.docx";
        String tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/DeleteTableCell_output.docx";
        tablesApi.deleteTableCell(name, tableRowPath, index, destFilePath, folder, storage, password);
    }
    public static void deleteTableRow() throws ApiException {
        String name = "deleteTableRow.docx";
        String tablePath = "Section/0/Body/0/Table/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/DeleteTableRow_output.docx";
        tablesApi.deleteTableRow(name, tablePath, index, destFilePath, folder, storage, password);
    }
    public static void getTableCells() throws ApiException {
        String name = "tableSample.docx";
        String tablePath = "Section/0/Body/0/Table/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = tablesApi.getTableCells(name, tablePath, index, folder, storage, password);
    }
    public static void getTableCellChildObjects() throws ApiException {
        String name = "tableSample.docx" ;
        String tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = tablesApi.getTableCellChildObjects(name, tableRowPath, index, folder, storage, password);
    }
    public static void getTableCellFormat() throws ApiException {
        String name = "getTableCellProperties.docx";
        String tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TableCellFormat response = tablesApi.getTableCellFormat(name, tableRowPath, index, folder, storage, password);
    }
    public static void getTableRows() throws ApiException {
        String name = "tableSample.docx";
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        List<ObjectInfo> response = tablesApi.getTableRows(name, nodePath, index, folder, storage, password);
    }
    public static void getTables() throws ApiException {
        String name = "tableSample.docx";
        String folder = "input";
        String storage = null;
        String password = null;
        String nodePath = "Section/0/Body/0";
        List<ObjectInfo> response = tablesApi.getTables(name, folder, storage, password, nodePath);
    }
    public static void getTableFormat() throws ApiException {
        String name = "getTableFormat.docx";
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TableFormat response = tablesApi.getTableFormat(name, nodePath, index, folder, storage, password);
    }
    public static void getTableRowFormat() throws ApiException {
        String name = "getTableRowFormat.docx";
        String tablePath = "Section/0/Body/0/Table/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TableRowFormat response = tablesApi.getTableRowFormat(name, tablePath, index, folder, storage, password);
    }
    public static void updateTableCellFormat() throws ApiException {
        String name = "updateTableCellFormat.docx";
        String tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        TableCellFormat cellFormat = new TableCellFormat();
        cellFormat.setWidth(new BigDecimal(100));
        Color color = new Color(100, 100, 100);
        cellFormat.setBackgroundColor(color);
        TableCellFormat format = cellFormat;
        String password = null;
        String destFilePath = "output/UpdateTableCellFormat_output.docx";
        tablesApi.updateTableCellFormat(name, tableRowPath, index, format, destFilePath, folder, storage, password);
    }
    public static void updateTableFormat() throws ApiException {
        String name = "updateTableFormat.docx";
        String nodePath = "Section/0/Body/0";
        Integer index = 0;
        String folder = "input";
        String storage = null;
        String password = null;
        TableFormat tableFormat = new TableFormat();
        tableFormat.setBidi(true);
        Border border = new Border();
        border.setBorderType(Border.BorderTypeEnum.DOT);
        Color color = new Color(255, 25, 2);
        border.setColor(color);
        border.setLineWidth(3f);
        Borders TopBorder = new Borders();
        TableFormat format= tableFormat;
        TopBorder.setTopBorder(border);
        tableFormat.setBorders(TopBorder);
        String destFilePath = "output/UpdateTableFormat_output.docx";
        tablesApi.updateTableFormat(name, nodePath, index, format, destFilePath, folder, storage, password);
    }
    public static void updateTableRowFormat() throws ApiException {
        String name = "updateTableRowFormat.docx";
        String tablePath = "Section/0/Body/0/Table/0";
        Integer index = 0;
        TableRowFormat rowFormat = new TableRowFormat();
        rowFormat.setHeight(100f);
        rowFormat.setHeightType(TableRowFormat.HeightTypeEnum.EXACTLY);
        rowFormat.setBreakAcrossPages(true);
        rowFormat.setHeader(true);
        TableRowFormat format = rowFormat;
        String folder = "input";
        String storage = null;
        String password = null;
        String destFilePath = "output/UpdateTableRowFormat_output.docx";
        tablesApi.updateTableRowFormat(name, tablePath, index, format, destFilePath,folder, storage, password);
    }
}
