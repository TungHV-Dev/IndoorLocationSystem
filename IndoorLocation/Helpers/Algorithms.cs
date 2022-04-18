using IndoorLocation.Configs;
using IndoorLocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IndoorLocation.Helpers
{
    public class Algorithms
    {
        public static Coordinates Localization(RSSI rssiData, List<DataPoint> processedData)
        {
            var nearestPoints = new NearestPoint[MapConfig.K_Nearest_Point];
            var distances = new double[MapConfig.max_Point];

            var sumOfInversion = 0d;
            var response = new Coordinates(0, 0);

            for (int i = 0; i < MapConfig.max_Point; i++)
            {
                distances[i] = RSSI.Distance(rssiData, processedData[i].RSSI);
            }

            for (int i = 0; i < MapConfig.K_Nearest_Point; i++)
            {
                nearestPoints[i] = new NearestPoint();
                nearestPoints[i].Index = 0;
                nearestPoints[i].Distance = double.MaxValue;
            }

            for (int i = 0; i < MapConfig.max_Point; i++)
            {
                if (distances[i] < nearestPoints[0].Distance)
                {
                    nearestPoints[2].Distance = nearestPoints[1].Distance;
                    nearestPoints[2].Index = nearestPoints[1].Index;
                    nearestPoints[1].Distance = nearestPoints[0].Distance;
                    nearestPoints[1].Index = nearestPoints[0].Index;
                    nearestPoints[0].Distance = distances[i];
                    nearestPoints[0].Index = i;
                }
                if (distances[i] > nearestPoints[0].Distance && distances[i] < nearestPoints[1].Distance)
                {
                    nearestPoints[2].Distance = nearestPoints[1].Distance;
                    nearestPoints[2].Index = nearestPoints[1].Index;
                    nearestPoints[1].Distance = distances[i];
                    nearestPoints[1].Index = i;
                }
                if (distances[i] > nearestPoints[1].Distance && distances[i] < nearestPoints[2].Distance)
                {
                    nearestPoints[2].Distance = distances[i];
                    nearestPoints[2].Index = i;
                }
            }

            for (int i = 0; i < MapConfig.K_Nearest_Point; i++)
            {
                sumOfInversion += 1.0 / nearestPoints[i].Distance;
            }

            for (int i = 0; i < MapConfig.K_Nearest_Point; i++)
            {
                nearestPoints[i].Coordinates = processedData[nearestPoints[i].Index].Coordinates;
                nearestPoints[i].Weighting = (1.0 / nearestPoints[i].Distance) / sumOfInversion;

                response.x += nearestPoints[i].Coordinates.x * nearestPoints[i].Weighting;
                response.y += nearestPoints[i].Coordinates.y * nearestPoints[i].Weighting;
            }

            return new Coordinates(Math.Round(response.x, 5), Math.Round(response.y, 5));
        }

        public static List<int> CreateListVerticesOfGraph()
        {
            var vertices = new List<int>();
            for (int i = 1; i <= MapConfig.VertexNumberInLength * MapConfig.VertexNumberInWidth; i++)
            {
                vertices.Add(i);
            }
            return vertices;
        }

        public static List<Edge> CreateListEdgesOfGraph(List<int> barriers = null)
        {
            var pointNumber = MapConfig.VertexNumberInWidth * MapConfig.VertexNumberInLength;
            var listEdge = new List<Edge>();

            // create list edge of graph without barriers
            for (int i = 1; i <= pointNumber; i++)
            {
                if (i % MapConfig.VertexNumberInWidth == 1)
                {
                    listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + 1 });
                    if (i + MapConfig.VertexNumberInWidth <= pointNumber)
                    {
                        listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + MapConfig.VertexNumberInWidth });
                        listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + MapConfig.VertexNumberInWidth + 1 });
                    }
                }
                else if (i % MapConfig.VertexNumberInWidth == 0)
                {
                    if (i + MapConfig.VertexNumberInWidth <= pointNumber)
                    {
                        listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + MapConfig.VertexNumberInWidth - 1 });
                        listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + MapConfig.VertexNumberInWidth });
                    }
                }
                else
                {
                    listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + 1 });
                    if (i + MapConfig.VertexNumberInWidth <= pointNumber)
                    {
                        listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + MapConfig.VertexNumberInWidth - 1 });
                        listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + MapConfig.VertexNumberInWidth });
                        listEdge.Add(new Edge { Vertex_1 = i, Vertex_2 = i + MapConfig.VertexNumberInWidth + 1 });
                    }
                }
            }

            // remove edges which contains barrier
            if (barriers != null)
            {
                foreach (var item in listEdge.ToList())
                {
                    if (barriers.Contains(item.Vertex_1) || barriers.Contains(item.Vertex_2))
                    {
                        listEdge.Remove(item);
                    }
                }
            }

            return listEdge;
        }

        public static Coordinates ConvertVertexToCoordinate(int vertex)
        {
            var x = (vertex - 1) / 18.0;

            if (x - Math.Floor(x) >= 0.5)
                x = Math.Floor(x) + 0.5;
            else
                x = Math.Floor(x);

            var y = (vertex - 18 * x - 1) / 2;

            return new Coordinates(x, y);
        }

        public static int ConvertCoordinateToVertex(Coordinates point)
        {
            return (int)(18 * point.x + 2 * point.y + 1);
        }

        public static List<Coordinates> RecalibrateCurrentPoint(Coordinates currentPoint, IEnumerable<int> barriers)
        {
            var pointSigns = new List<Coordinates>();
            var x_currentDecimal = currentPoint.x - Math.Floor(currentPoint.x);
            var y_currentDecimal = currentPoint.y - Math.Floor(currentPoint.y);

            if (x_currentDecimal <= 0.5 && y_currentDecimal <= 0.5)
            {
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x), Math.Floor(currentPoint.y)));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x), Math.Floor(currentPoint.y) + 0.5));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y)));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y) + 0.5));
            }
            else if (x_currentDecimal <= 0.5 && y_currentDecimal > 0.5)
            {
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x), Math.Floor(currentPoint.y) + 0.5));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x), Math.Floor(currentPoint.y) + 1));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y) + 0.5));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y) + 1));
            }
            else if (x_currentDecimal > 0.5 && y_currentDecimal <= 0.5)
            {
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y)));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y) + 0.5));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 1, Math.Floor(currentPoint.y)));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 1, Math.Floor(currentPoint.y) + 0.5));
            }
            else
            {
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y) + 0.5));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 0.5, Math.Floor(currentPoint.y) + 1));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 1, Math.Floor(currentPoint.y) + 0.5));
                pointSigns.Add(new Coordinates(Math.Floor(currentPoint.x) + 1, Math.Floor(currentPoint.y) + 1));
            }

            var listPoint = new List<Coordinates>();

            foreach (var item in pointSigns)
            {
                if (!barriers.Contains(ConvertCoordinateToVertex(item)))
                {
                    listPoint.Add(item);
                }
            }

            return listPoint;
        }

        public static HashSet<int> BFS(Graph graph, int start)
        {
            var visited = new HashSet<int>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var queue = new Queue<int>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
            }

            return visited;
        }

        public static Func<int, IEnumerable<int>> ShortestPathFunction(Graph graph, int start)
        {
            var previous = new Dictionary<int, int>();

            var queue = new Queue<int>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    if (previous.ContainsKey(neighbor))
                        continue;

                    previous[neighbor] = vertex;
                    queue.Enqueue(neighbor);
                }
            }

            Func<int, IEnumerable<int>> shortestPath = v => {
                var path = new List<int> { };

                var current = v;
                while (!current.Equals(start))
                {
                    path.Add(current);
                    current = previous[current];
                };

                path.Add(start);
                path.Reverse();

                return path;
            };

            return shortestPath;
        }
    }
}
