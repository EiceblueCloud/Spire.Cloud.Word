using Spire.Cloud.Word.Sdk.Api;
using Spire.Cloud.Word.Sdk.Client;
using Spire.Cloud.Word.Sdk.Model;
using System;

namespace CloudWord
{
    class TablesApiDemo
    {
        static String appId = "your id";
        static String appKey = "your key";
        static string basePath = "https://api.e-iceblue.cn";
        static Configuration wordConfiguration = new Configuration(appId, appKey, basePath);
        static TablesApi tablesApi = new TablesApi(wordConfiguration);
        public static void AddTable()
        {
            string name = "tableSample.docx";
            string nodePath = "Section/0/Body/0";
            int indexOfTable = 0;
            int? rowsCount = 6;
            int? columnsCount = 6;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/AddTable_output.docx" ;
            tablesApi.AddTable(name, nodePath, rowsCount, columnsCount, destFilePath, folder, storage, indexOfTable, password);
        }
        public static void AddTableCell()
        {          
            string name = "addTableCell.docx";
            string tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
            int indexOfTableCell = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/AddTableCell_output.docx";
            tablesApi.AddTableCell(name, tableRowPath, destFilePath, folder, storage, indexOfTableCell, password);
        }
        public static void AddTableRow()
        {
            string name = "addTableRow.docx";
            string tablePath = "Section/0/Body/0/Table/0";
            int indexOfTableRow = 0;
            string folder = "input";
            string storage = null;
            int? cellsCount = 3;
            string password = null;
            string destFilePath = "output/AddTableRow_output.docx";
            tablesApi.AddTableRow(name, tablePath, destFilePath,folder, storage, indexOfTableRow, cellsCount, password);
        }
        public static void DeleteTable()
        {
            string name = "deleteTable.docx";
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTable_output.docx";
            tablesApi.DeleteTable(name, nodePath, index, destFilePath, folder, storage, password);
        }
        public static void DeleteTableCell()
        {
            string name = "deleteTableCell.docx";
            string tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTableCell_output.docx";
            tablesApi.DeleteTableCell(name, tableRowPath, index, destFilePath, folder, storage, password);
        }
        public static void DeleteTableRow()
        {           
            string name = "deleteTableRow.docx";
            string tablePath = "Section/0/Body/0/Table/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTableRow_output.docx";
            tablesApi.DeleteTableRow(name, tablePath, index, destFilePath, folder, storage, password);
        }
        public static void GetTableCells()
        {
            string name = "tableSample.docx";
            string tablePath = "Section/0/Body/0/Table/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableCells(name, tablePath, index, folder, storage, password);
        }
        public static void GetTableCellChildObjects()
        {
            string name = "tableSample.docx" ;
            string tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableCellChildObjects(name, tableRowPath, index, folder, storage, password);
        }
        public static void GetTableCellFormat()
        {
            string name = "getTableCellProperties.docx";
            string tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableCellFormat(name, tableRowPath, index, folder, storage, password);
        }
        public static void GetTableRows()
        {
            string name = "tableSample.docx";
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableRows(name, nodePath, index, folder, storage, password);
        }
        public void GetTables()
        {
            string name = "tableSample.docx";
            string folder = "input";
            string storage = null;
            string password = null;
            string nodePath = "Section/0/Body/0";
            var response = tablesApi.GetTables(name, folder, storage, password, nodePath);
        }
        public static void GetTableFormat()
        {
            string name = "getTableFormat.docx";
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableFormat(name, nodePath, index, folder, storage, password);
        }
        public static void GetTableRowFormat()
        {
            string name = "getTableRowFormat.docx";
            string tablePath = "Section/0/Body/0/Table/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableRowFormat(name, tablePath, index, folder, storage, password);
        }
        public static void UpdateTableCellFormat()
        {
            string name = "updateTableCellFormat.docx";
            string tableRowPath = "Section/0/Body/0/Table/0/TableRow/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            TableCellFormat format = new TableCellFormat
            {
                Width = 1000,
                BackgroundColor = new Color(100, 100, 100)
            };
            string password = null;
            string destFilePath = "output/UpdateTableCellFormat_output.docx";
            tablesApi.UpdateTableCellFormat(name, tableRowPath, index, format, destFilePath, folder, storage, password);
        }
        public static void UpdateTableFormat()
        {          
            string name = "updateTableFormat.docx";
            string nodePath = "Section/0/Body/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            TableFormat tableFormat = new TableFormat
            {
                Bidi = false,
                Borders = new Borders
                {
                    TopBorder = new Border
                    {
                        BorderType = Border.BorderTypeEnum.Dot,
                        Color = new Color(255, 25, 1),
                        LineWidth = 3
                    }
                }
            };
            string destFilePath = "output/UpdateTableFormat_output.docx";
            tablesApi.UpdateTableFormat(name, nodePath, index, tableFormat, destFilePath, folder, storage, password);
        }
        public static void UpdateTableRowFormat()
        {            
            string name = "updateTableRowFormat.docx";
            string tablePath = "Section/0/Body/0/Table/0";
            int? index = 0;
            TableRowFormat format = new TableRowFormat
            {
                Height = 100,
                HeightType = TableRowFormat.HeightTypeEnum.Exactly,
                BreakAcrossPages = true,
                Header = true
            };
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/UpdateTableRowFormat_output.docx";
            tablesApi.UpdateTableRowFormat(name, tablePath, index, format, destFilePath,folder, storage, password);
        }
    }
}
