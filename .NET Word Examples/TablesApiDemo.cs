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
        public static void AddTableCell()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "addTableCell.docx";
            string name = fileName;
            string tableRowPath = "sections/0/tables/0/rows/0";
            int indexOfTableCell = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/AddTableCell_output.docx";
            tablesApi.AddTableCell(name, tableRowPath, folder, storage, indexOfTableCell, password, destFilePath);
        }
        public static void AddTableRow()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "addTableRow.docx";
            string name = fileName;
            string tablePath = "sections/0/tables/0";
            int indexOfTableRow = 0;
            string folder = "input";
            string storage = null;
            int? cellsCount = 3;
            string password = null;
            string destFilePath = "output/AddTableRow_output.docx";
            tablesApi.AddTableRow(name, tablePath, folder, storage, indexOfTableRow, cellsCount, password, destFilePath);
        }
        public static void AddTable()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "addTable.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int indexOfTable = 0;
            int? rowsCount = 6;
            int? columnsCount = 6;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/AddTable_output.docx";
            tablesApi.AddTable(name, nodePath, rowsCount, columnsCount, folder, storage, indexOfTable, password, destFilePath);
        }
        public static void DeleteTableCell()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "deleteTableCell.docx";
            string name = fileName;
            string tableRowPath = "sections/0/tables/0/rows/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTableCell_output.docx";
            tablesApi.DeleteTableCell(name, tableRowPath, index, folder, storage, password, destFilePath);
        }
        public static void DeleteTableRow()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "deleteTableRow.docx";
            string name = fileName;
            string tablePath = "sections/0/tables/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTableRow_output.docx";
            tablesApi.DeleteTableRow(name, tablePath, index, folder, storage, password, destFilePath);
        }
        public static void DeleteTable()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "deleteTable.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            string destFilePath = "output/DeleteTable_output.docx";
            tablesApi.DeleteTable(name, nodePath, index, folder, storage, password, destFilePath);
        }
        public static void GetTableCellProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "getTableCellProperties.docx";
            string name = fileName;
            string tableRowPath = "sections/0/tables/0/rows/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableCellProperties(name, tableRowPath, index, folder, storage, password);
        }
        public static void GetTableProperties()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "getTableProperties.docx";
            string name = fileName;
            string nodePath = "sections/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableProperties(name, nodePath, index, folder, storage, password);
        }
        public static void GetTableRowFormat()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "getTableRowFormat.docx";
            string name = fileName;
            string tablePath = "sections/0/tables/0";
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            var response = tablesApi.GetTableRowFormat(name, tablePath, index, folder, storage, password);
        }
        public static void UpdateTableCellFormat()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "updateTableCellFormat.docx";
            string name = fileName;
            string tableRowPath = "sections/0/tables/0/rows/0";
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
            tablesApi.UpdateTableCellFormat(name, tableRowPath, index, format, folder, storage, password, destFilePath);
        }
        public static void UpdateTableFormat()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "updateTableFormat.docx";
            string name = fileName;
            string nodePath = "sections/0"; ;
            int? index = 0;
            string folder = "input";
            string storage = null;
            string password = null;
            TableFormat properties = new TableFormat
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
            tablesApi.UpdateTableFormat(name, nodePath, index, properties, folder, storage, password, destFilePath);
        }
        public static void UpdateTableRowFormat()
        {
            Configuration wordConfiguration = new Configuration(appId, appKey);
            TablesApi tablesApi = new TablesApi(wordConfiguration);
            var fileName = "updateTableRowFormat.docx";
            string name = fileName;
            string tablePath = "sections/0/tables/0";
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
            tablesApi.UpdateTableRowFormat(name, tablePath, index, format, folder, storage, password, destFilePath);
        }
    }
}
