using IndoorLocation.Configs;
using IndoorLocation.Helpers;
using IndoorLocation.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace IndoorLocation
{
    public partial class Form1 : Form
    {
        private bool IsStartApp = false;
        private GraphPane Map;
        private List<int> Barriers;

        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            InitMap();
        }

        private void SelectMapTypeEvent(object sender, EventArgs e)
        {
            if (MessageBox.Show("Click Yes to confirm!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                switch (int.Parse(comboBox_mapType.Text))
                {
                    case 1:
                        {
                            Barriers = BarrierConfig.Barrier1;

                            var barrierLine1 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 2, Y = 2.5 }, new PointPair { X = 2, Y = 3 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine2 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 2, Y = 3 }, new PointPair { X = 5, Y = 3 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine3 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 5, Y = 2.5 }, new PointPair { X = 5, Y = 3 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine4 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 2, Y = 1 }, new PointPair { X = 2, Y = 1.5 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine5 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 5, Y = 1 }, new PointPair { X = 5, Y = 1.5 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine6 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 2, Y = 1 }, new PointPair { X = 5, Y = 1 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            Map.CurveList.Add(barrierLine1);
                            Map.CurveList.Add(barrierLine2);
                            Map.CurveList.Add(barrierLine3);
                            Map.CurveList.Add(barrierLine4);
                            Map.CurveList.Add(barrierLine5);
                            Map.CurveList.Add(barrierLine6);
                        }
                        break;
                    case 2:
                        {
                            Barriers = BarrierConfig.Barrier2;

                            var barrierLine1 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 1.5, Y = 1 }, new PointPair { X = 1.5, Y = 1.5 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine2 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 1.5, Y = 2.5 }, new PointPair { X = 1.5, Y = 3 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine3 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 2.5, Y = 1.5 }, new PointPair { X = 3.5, Y = 1.5 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine4 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 2.5, Y = 2.5 }, new PointPair { X = 3.5, Y = 2.5 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine5 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 3, Y = 1.5 }, new PointPair { X = 3, Y = 2.5 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine6 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 4.5, Y = 1 }, new PointPair { X = 5.5, Y = 1 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine7 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 4.5, Y = 3 }, new PointPair { X = 5.5, Y = 3 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine8 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 5.5, Y = 1 }, new PointPair { X = 5.5, Y = 1.5 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            var barrierLine9 = new LineItem(
                                label: string.Empty,
                                points: new PointPairList { new PointPair { X = 5.5, Y = 2.5 }, new PointPair { X = 5.5, Y = 3 } },
                                color: Color.Green,
                                symbolType: SymbolType.None,
                                lineWidth: MapConfig.BarrierLineWidth);

                            Map.CurveList.Add(barrierLine1);
                            Map.CurveList.Add(barrierLine2);
                            Map.CurveList.Add(barrierLine3);
                            Map.CurveList.Add(barrierLine4);
                            Map.CurveList.Add(barrierLine5);
                            Map.CurveList.Add(barrierLine6);
                            Map.CurveList.Add(barrierLine7);
                            Map.CurveList.Add(barrierLine8);
                            Map.CurveList.Add(barrierLine9);
                        }
                        break;
                }
                zedGraphControl_map.Invalidate();
                comboBox_mapType.Enabled = false;
            }
        }

        private async void CreateProcessedDataEvent(object sender, EventArgs e)
        {
            var response = await DataHandler.CreateProcessedData();
            if (response.Equals(string.Empty))
            {
                MessageBox.Show("Create processed data successfully!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(response, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private async void ExportDataEvent(object sender, EventArgs e)
        {
            if (saveFileDialog_save_data.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog_save_data.FileName;
                var response = await DataHandler.ExportCollectedDataToExcel(filePath);

                if (response.Equals(string.Empty))
                {
                    MessageBox.Show("Export data to excel successfully!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show(response, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private async void StartAppEvent(object sender, EventArgs e)
        {
            // Choose the map type
            if (string.IsNullOrEmpty(comboBox_mapType.Text))
            {
                MessageBox.Show("The map type is required!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Choose and display destination point
            if (string.IsNullOrEmpty(comboBox_X_des.Text) || string.IsNullOrEmpty(comboBox_Y_des.Text))
            {
                MessageBox.Show("Destination point's coordinates is required!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dbConnection = new FirebaseConnection();
            var destinationPoint = new Coordinates(double.Parse(comboBox_X_des.Text), double.Parse(comboBox_Y_des.Text));
            if (Barriers.Contains(Algorithms.ConvertCoordinateToVertex(destinationPoint)))
            {
                MessageBox.Show("Destination point's coordinates is invalid!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            await dbConnection .PutCoordinates(destinationPoint, FirebaseConfig.Key.Destination_Point);
            DrawPoint(destinationPoint, Color.Empty, Color.Blue);
            comboBox_X_des.Enabled = false;
            comboBox_Y_des.Enabled = false;

            // Active app
            IsStartApp = true;
            var count = 0;
            var lastActualPoints = new Coordinates();
            var lastCaculationPoints = new Coordinates();
            var processedData = await dbConnection.GetProcessedData();

            while (IsStartApp)
            {
                await Task.Delay(1);
                var rssiData = await dbConnection.GetDataInCurrentPoint();
                var currentPoint = Algorithms.Localization(rssiData, processedData);

                textBox_X_cur.Text = currentPoint.x.ToString();
                textBox_Y_cur.Text = currentPoint.y.ToString();

                if (count == 0)
                {
                    count++;
                    lastActualPoints = currentPoint;
                    lastCaculationPoints = currentPoint;
                    DrawPoint(currentPoint, Color.Empty, Color.Coral);    // display the start point
                }
                else
                {   
                    DrawPoint(currentPoint, Color.Empty, Color.Red);    // display the current point
                }

                // draw the actual path of robot
                var actualBorder = new LineItem(
                    label: string.Empty,
                    points: new PointPairList
                    {
                        new PointPair { X = currentPoint.x, Y = currentPoint.y },
                        new PointPair { X = lastActualPoints.x, Y = lastActualPoints.y }
                    },
                    color: Color.Red,
                    symbolType: SymbolType.None,
                    lineWidth: MapConfig.PathWidth);

                Map.CurveList.Add(actualBorder);

                if (Coordinates.Distance(currentPoint, destinationPoint) <= MapConfig.StopDistance)
                {
                    MessageBox.Show("Robot has reached the destination point!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Find the shotest path
                var listCurrentPoint = Algorithms.RecalibrateCurrentPoint(currentPoint, Barriers);
                var edges = Algorithms.CreateListEdgesOfGraph(Barriers);
                var vertices = Algorithms.CreateListVerticesOfGraph();
                var graph = new Graph(vertices, edges);
                var minVertexNumber = MapConfig.VertexNumberInWidth * MapConfig.VertexNumberInLength + 1;
                var shortestPathResult = new List<int>();

                foreach (var point in listCurrentPoint)
                {
                    var findShortestPath = Algorithms.ShortestPathFunction(graph, Algorithms.ConvertCoordinateToVertex(point));
                    var shortestPath = findShortestPath(Algorithms.ConvertCoordinateToVertex(destinationPoint)).ToList();

                    if (shortestPath.Count() < minVertexNumber)
                    {
                        minVertexNumber = shortestPath.Count();
                        shortestPathResult = shortestPath;
                    }
                }

                if (shortestPathResult == null || shortestPathResult.Count() == 0)
                {
                    MessageBox.Show("The path to destination point does not exist!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // find the next point
                Coordinates nextPoint;
                if (shortestPathResult.Count() > 1)
                {
                    var checkPoint = Algorithms.ConvertVertexToCoordinate(shortestPathResult[0]);
                    if (Coordinates.Distance(checkPoint, currentPoint) > 0.3)
                    {
                        nextPoint = checkPoint;
                    }
                    else
                    {
                        nextPoint = Algorithms.ConvertVertexToCoordinate(shortestPathResult[1]);
                    }
                }
                else
                {
                    nextPoint = Algorithms.ConvertVertexToCoordinate(shortestPathResult[0]);
                }

                await dbConnection .PutCoordinates(nextPoint, FirebaseConfig.Key.Next_Point);
                textBox_nextPos_x.Text = nextPoint.x.ToString();
                textBox_nextPos_y.Text = nextPoint.y.ToString();
                DrawPoint(nextPoint, Color.Empty, Color.Gray);

                // draw the caculation path of robot
                var caculationBorder = new LineItem(
                    label: string.Empty,
                    points: new PointPairList
                    {
                        new PointPair { X = nextPoint.x, Y = nextPoint.y },
                        new PointPair { X = lastCaculationPoints.x, Y = lastCaculationPoints.y }
                    },
                    color: Color.Gray,
                    symbolType: SymbolType.None,
                    lineWidth: MapConfig.PathWidth);

                Map.CurveList.Add(caculationBorder);

                // update last actual point and last caculation point
                lastActualPoints = currentPoint;
                lastCaculationPoints = nextPoint;

                zedGraphControl_map.Invalidate();
            }
        }

        private void ExitAppEvent(object sender, EventArgs e)
        {
            IsStartApp = false;
            MessageBox.Show("Goodbye!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        #endregion

        #region Extention Methods
        private void InitMap()
        {
            #region Init basic map
            zedGraphControl_map.IsEnableZoom = false;
            zedGraphControl_map.IsShowPointValues = true;

            Map = zedGraphControl_map.GraphPane;
            Map.Title.Text = "The location and navigation process of robot";
            Map.Title.FontSpec.IsBold = false;

            // Set up X axis
            Map.XAxis.Title.Text = "X axis";
            Map.XAxis.Scale.Min = -1;
            Map.XAxis.Scale.Max = 8;
            Map.XAxis.Scale.MajorStep = 1;
            Map.XAxis.Scale.MinorStep = 0.5;

            // Set up Y axis
            Map.YAxis.Title.Text = "Y axis";
            Map.YAxis.Scale.Min = -1;
            Map.YAxis.Scale.Max = 5;
            Map.YAxis.Scale.MajorStep = 1;
            Map.YAxis.Scale.MinorStep = 0.5;

            #endregion

            #region Set up the borders of the map
            var border1 = new LineItem(
                label: string.Empty,
                points: new PointPairList { new PointPair { X = 0, Y = 0 }, new PointPair { X = 0, Y = 4 } },
                color: Color.Red,
                symbolType: SymbolType.None,
                lineWidth: MapConfig.BorderMapWidth);

            var border2 = new LineItem(
                label: string.Empty,
                points: new PointPairList { new PointPair { X = 0, Y = 0 }, new PointPair { X = 7, Y = 0 } },
                color: Color.Red,
                symbolType: SymbolType.None,
                lineWidth: MapConfig.BorderMapWidth);

            var border3 = new LineItem(
                label: string.Empty,
                points: new PointPairList { new PointPair { X = 0, Y = 4 }, new PointPair { X = 7, Y = 4 } },
                color: Color.Red,
                symbolType: SymbolType.None,
                lineWidth: MapConfig.BorderMapWidth);

            var border4 = new LineItem(
                label: string.Empty,
                points: new PointPairList { new PointPair { X = 7, Y = 0 }, new PointPair { X = 7, Y = 4 } },
                color: Color.Red,
                symbolType: SymbolType.None,
                lineWidth: MapConfig.BorderMapWidth);

            Map.CurveList.Add(border1);
            Map.CurveList.Add(border2);
            Map.CurveList.Add(border3);
            Map.CurveList.Add(border4);

            #endregion

            #region Set up the grid of the coordinate system
            for (int i = -1; i <= MapConfig.max_X; i++)
            {
                if (i >= 0)
                {
                    var solidLine = Map.AddCurve(
                        label: string.Empty,
                        points: new PointPairList { new PointPair { X = i, Y = -1 }, new PointPair { X = i, Y = 5 } },
                        color: Color.Black,
                        symbolType: SymbolType.None);

                    solidLine.Line.Style = DashStyle.Solid;
                    solidLine.Line.Width = MapConfig.SolidLineGridWidth;
                }

                var lineItem = Map.AddCurve(
                    label: string.Empty,
                    points: new PointPairList { new PointPair { X = i + 0.5, Y = -1 }, new PointPair { X = i + 0.5, Y = 5 } },
                    color: Color.Black,
                    symbolType: SymbolType.None);

                lineItem.Line.Style = DashStyle.Dot;
                lineItem.Line.Width = MapConfig.DashLineGridWidth;
            }

            for (int i = -1; i <= MapConfig.max_Y; i++)
            {
                if (i > 0)
                {
                    var solidLine = Map.AddCurve(
                        label: string.Empty,
                        points: new PointPairList { new PointPair { X = -1, Y = i }, new PointPair { X = 8, Y = i } },
                        color: Color.Black,
                        symbolType: SymbolType.None);

                    solidLine.Line.Style = DashStyle.Solid;
                    solidLine.Line.Width = MapConfig.SolidLineGridWidth;
                }

                var dashLine = Map.AddCurve(
                    label: string.Empty,
                    points: new PointPairList { new PointPair { X = -1, Y = i + 0.5 }, new PointPair { X = 8, Y = i + 0.5 } },
                    color: Color.Black,
                    symbolType: SymbolType.None);

                dashLine.Line.Style = DashStyle.Dot;
                dashLine.Line.Width = MapConfig.DashLineGridWidth;
            }

            #endregion

            #region Display access point
            DrawPoint(new Coordinates { x = -0.5, y = 0.5 }, Color.Red, Color.Yellow);
            DrawPoint(new Coordinates { x = -0.5, y = 3.5 }, Color.Red, Color.Yellow);
            DrawPoint(new Coordinates { x = 7.5, y = 0.5 }, Color.Red, Color.Yellow);
            DrawPoint(new Coordinates { x = 7.5, y = 3.5 }, Color.Red, Color.Yellow);

            #endregion

            zedGraphControl_map.Invalidate();
        }

        private void DrawPoint(Coordinates point, Color borderColor, Color fillColor)
        {
            var graphObj = new BoxObj(point.x - MapConfig.PointWidth / 2, point.y + MapConfig.PointHeigh / 2, MapConfig.PointWidth, MapConfig.PointHeigh, borderColor, fillColor);
            if (!borderColor.IsEmpty)
            {
                graphObj.Border.Width = MapConfig.BorderPointWidth;
            }
            Map.GraphObjList.Add(graphObj);
            zedGraphControl_map.Invalidate();
        }

        #endregion
    }
}
