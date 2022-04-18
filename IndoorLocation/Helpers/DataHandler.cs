using IndoorLocation.Configs;
using IndoorLocation.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IndoorLocation.Helpers
{
    public class DataHandler
    {
        public static async Task<string> CreateProcessedData()
        {
            try
            {
                var dbConnection = new FirebaseConnection();
                var collectedData = await dbConnection.GetCollectedData();
                var listDataPoint = new List<DataPoint>();

                for (int i = 0; i < MapConfig.max_Point; i++)
                {
                    var x_current = i / 5;
                    var y_current = i - 5 * x_current;

                    var rssiData = new RSSI(0, 0, 0, 0);

                    for (int j = 0; j < MapConfig.max_DataRSSI_In_One_Point; j++)
                    {
                        rssiData.RSSI_A += collectedData.ElementAt(i).Object[j].RSSI_A;
                        rssiData.RSSI_B += collectedData.ElementAt(i).Object[j].RSSI_B;
                        rssiData.RSSI_C += collectedData.ElementAt(i).Object[j].RSSI_C;
                        rssiData.RSSI_D += collectedData.ElementAt(i).Object[j].RSSI_D;
                    }

                    rssiData = new RSSI
                    {
                        RSSI_A = rssiData.RSSI_A / MapConfig.max_DataRSSI_In_One_Point,
                        RSSI_B = rssiData.RSSI_B / MapConfig.max_DataRSSI_In_One_Point,
                        RSSI_C = rssiData.RSSI_C / MapConfig.max_DataRSSI_In_One_Point,
                        RSSI_D = rssiData.RSSI_D / MapConfig.max_DataRSSI_In_One_Point,
                    };

                    listDataPoint.Add(new DataPoint
                    {
                        Coordinates = new Coordinates(x_current, y_current),
                        RSSI = rssiData
                    });
                }

                await dbConnection.PutProcessedData(listDataPoint);
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }

        public static async Task<string> ExportCollectedDataToExcel(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                var dbConnection = new FirebaseConnection();
                var collectedData = await dbConnection.GetCollectedData();

                using (var package = new ExcelPackage())
                {
                    package.Workbook.Properties.Author = "Ha Van Tung";
                    package.Workbook.Properties.Title = "Collected Data RSSI";
                    package.Workbook.Worksheets.Add("CollectedData");

                    var workSheet = package.Workbook.Worksheets[0];
                    workSheet.Cells.Style.Font.Size = 12;
                    workSheet.Cells.Style.Font.Name = "Arial";

                    string[] columnHeader = { "x", "y", "RSSI_A", "RSSI_B", "RSSI_C", "RSSI_D" };
                    var countColumnHeader = columnHeader.Count();

                    var colIndex = 1;
                    var rowIndex = 1;

                    foreach (var item in columnHeader)
                    {
                        var cell = workSheet.Cells[rowIndex, colIndex];
                        cell.Value = item;
                        colIndex++;
                    }

                    for (int i = 0; i < MapConfig.max_Point; i++)
                    {
                        var x_current = i / 5;
                        var y_current = i - 5 * x_current;

                        for (int j = 0; j < MapConfig.max_DataRSSI_In_One_Point; j++)
                        {
                            colIndex = 1;
                            rowIndex++;

                            workSheet.Cells[rowIndex, colIndex++].Value = x_current;
                            workSheet.Cells[rowIndex, colIndex++].Value = y_current;
                            workSheet.Cells[rowIndex, colIndex++].Value = collectedData.ElementAt(i).Object[j].RSSI_A;
                            workSheet.Cells[rowIndex, colIndex++].Value = collectedData.ElementAt(i).Object[j].RSSI_B;
                            workSheet.Cells[rowIndex, colIndex++].Value = collectedData.ElementAt(i).Object[j].RSSI_C;
                            workSheet.Cells[rowIndex, colIndex++].Value = collectedData.ElementAt(i).Object[j].RSSI_D;
                        }
                    }

                    byte[] bin = package.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static async Task ImportCollectedDataToFirebase()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var package = new ExcelPackage(new FileInfo("ImportRSSI.xlsx"));
            var workSheet = package.Workbook.Worksheets[0];
            var listDataPoints = new List<DataPoint>();
            var firebase = new FirebaseConnection();

            for (int row = workSheet.Dimension.Start.Row + 1; row <= workSheet.Dimension.End.Row; row++)
            {
                var column = 1;
                var dataPoint = new DataPoint
                {
                    Coordinates = new Coordinates
                    {
                        x = (double)workSheet.Cells[row, column++].Value,
                        y = (double)workSheet.Cells[row, column++].Value
                    },
                    RSSI = new RSSI
                    {
                        RSSI_A = (double)workSheet.Cells[row, column++].Value,
                        RSSI_B = (double)workSheet.Cells[row, column++].Value,
                        RSSI_C = (double)workSheet.Cells[row, column++].Value,
                        RSSI_D = (double)workSheet.Cells[row, column++].Value
                    }
                };
                listDataPoints.Add(dataPoint);
            }

            await firebase.PutCollectedData(listDataPoints);
        }
    }
}
