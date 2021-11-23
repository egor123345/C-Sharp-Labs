using System;
using System.Linq;

using System.Collections.Generic;

namespace Dijkstra
{
    class Program
    {
        public class Vertex
        {
            public int Number { get; set; }
            public float Distance { get; set; }
            public Vertex NearestVertex { get; set; }
           

        }

        public class VertexComparer : IComparer<Vertex>
        {
            public int Compare(Vertex a, Vertex b)
            {
                return a.Distance.CompareTo(b.Distance);
            }
        }
        public class Graph
        {
            private float[][] WeightMatrix;
            private List<Vertex> vertices;
            public int startVertex { get; set; }
            public float[][] ReadMatrix()
            {
                Console.WriteLine("Введите количество вершин");
                int n = int.Parse(Console.ReadLine());
                WeightMatrix = new float[n][];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Введите веса для вершины {(char)('A' + i)}");
                    WeightMatrix[i] = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToArray();
                    while (WeightMatrix[i].Any(s => s < 0) || WeightMatrix[i][i] != 0)
                    {
                        Console.WriteLine("В графе не может быть петель и отрицательных вершин!");
                        Console.WriteLine($"Введите веса для вершины {i}");
                        WeightMatrix[i] = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToArray();
                    }
                }
                return WeightMatrix;
            }
            public void PrintMatrix()
            {
                Console.WriteLine("Матрица Весов");

                for (int i = 0; i < WeightMatrix.Length; i++)
                {
                    for (int j = 0; j < WeightMatrix[i].Length; j++)
                    {
                        Console.Write(WeightMatrix[i][j]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }

            public List<Vertex> Dijkstra(int startVertex)
            {
                this.startVertex = startVertex;
                var queue = new C5.IntervalHeap<Vertex>(new VertexComparer());
                for (int i = 0; i < WeightMatrix.Length; i++)
                {
                    queue.Add(new Vertex() { Distance = startVertex == i ? 0 : float.PositiveInfinity, 
                                                Number = i, NearestVertex = null});
                }
           
                vertices = new List<Vertex>();
                while (queue.Any() && queue.FindMin().Distance != float.PositiveInfinity)
                {
                    Vertex curentVertex = queue.DeleteMin();
                    if (curentVertex.Number == -1)
                    {
                        continue;
                    }
                    vertices.Add(curentVertex);
                    List<Vertex> UpdVertices = new List<Vertex>();
                    foreach (Vertex vertex in queue)
                    {
                        if (vertex.Number != -1  && WeightMatrix[curentVertex.Number][vertex.Number] != 0 &&
                        curentVertex.Distance + WeightMatrix[curentVertex.Number][vertex.Number] < vertex.Distance)
                        {
                            UpdVertices.Add(new Vertex () { Distance = curentVertex.Distance + WeightMatrix[curentVertex.Number][vertex.Number],
                                NearestVertex = curentVertex, Number = vertex.Number });
                            vertex.Number = -1;

                        }
                    }
                    foreach (Vertex vertex in UpdVertices)
                    {
                        queue.Add(vertex);
                    }
                    Console.WriteLine(queue.FindMin().Distance); // временно

                }
                while (queue.Any())
                {
                    Vertex temp = queue.DeleteMin();
                    if (temp.Number != -1)
                    {
                        vertices.Add(temp);
                    }
                }
                return vertices;


            }

            public Stack<char> getRoadToVertex(Vertex vertex)
            {
                var RoadToVertex = new Stack<char>();
                RoadToVertex.Push((char)('A' + vertex.Number));
                while (vertex.NearestVertex != null)
                {
                    RoadToVertex.Push((char)('A' + vertex.NearestVertex.Number));
                    vertex = vertex.NearestVertex;
                }
                return RoadToVertex;
            }
            public void ShowDistanceVertex()
            {
                Console.WriteLine($"Расстояния от Вершины {(char)('A' + startVertex)}"); 
                foreach (Vertex vertex in vertices)
                {
                    if (vertex.Distance != 0)
                    {
                    Console.WriteLine($"Вершина : {(char)('A' + vertex.Number)} Расстояние до вершины {vertex.Distance} " +
                             $"Ближайшая соседняя вершина {( vertex.NearestVertex != null ? ( (char)('A' + vertex.NearestVertex.Number)) : '-')}");
                    Stack<char> RoadToVertex = getRoadToVertex(vertex);
                    string Road = "Ближайший путь: ";
                    while (RoadToVertex.Any())
                    {
                        Road += RoadToVertex.Pop();
                        if (RoadToVertex.Any())
                            {
                                Road += " -> ";
                            }
                    }
                    Console.WriteLine(Road);
                    }
                    else
                    {
                        Console.WriteLine($"Начальная вершина {(char)('A' +vertex.Number)} ");
                    }
                    Console.WriteLine();
                }
            }
        }
        
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.ReadMatrix();
            graph.PrintMatrix();
            Console.WriteLine("Введите начальную вершину");
            int startVertex =  char.Parse(Console.ReadLine()) - 'A';
            List<Vertex> vertices = graph.Dijkstra(startVertex);
            graph.ShowDistanceVertex();
               
          
        }
    }
}


