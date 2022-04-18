using System.Collections.Generic;

namespace IndoorLocation.Models
{
    public class Graph
    {
        // Danh sach cac dinh lien ke
        public Dictionary<int, HashSet<int>> AdjacencyList { get; } = new Dictionary<int, HashSet<int>>();

        public Graph() { }
        public Graph(IEnumerable<int> vertices, IEnumerable<Edge> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        public void AddVertex(int vertex)
        {
            AdjacencyList[vertex] = new HashSet<int>();
        }

        public void AddEdge(Edge edge)
        {
            if (AdjacencyList.ContainsKey(edge.Vertex_1) && AdjacencyList.ContainsKey(edge.Vertex_2))
            {
                AdjacencyList[edge.Vertex_1].Add(edge.Vertex_2);
                AdjacencyList[edge.Vertex_2].Add(edge.Vertex_1);
            }
        }
    }
}
