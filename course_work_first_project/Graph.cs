using System;
using System.Collections.Generic;


namespace course_work_first_project
{
    class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        public int VertexCount { get => Vertexes.Count; }
        public int EdgeCount { get => Edges.Count; }
        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);

        }
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }
        public int[,] GetMatrix()//матрица смежности
        {
            var matrix = new int[Vertexes.Count, Edges.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var colums = edge.To.Number - 1;

                matrix[row, colums] = edge.Weight;
            }
            return matrix;
        }
        public List<Vertex> GetVertexLists(Vertex vertex)//передаем вершину и получаем межные с ней
        {

            var result = new List<Vertex>();
            foreach (var edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }
        /*
        public bool Wave(Vertex start, Vertex finish) // алгоритм волны
        {
            

            var list = new List<Vertex>();
                list.Add(start);
            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var v in GetVertexLists(vertex))
                {
                    if(!list.Contains(v))
                    {
                        
                        list.Add(v);
                    }
                    
                }
            }

            return list.Contains(finish);
        }
        */

        public static void  PrintVertex(Graph graph, Vertex vertex)
        {
            
            Console.WriteLine($"Вы находитесь в локации : {vertex.Name}");
            Console.WriteLine("Вы можете пройти в следующие локации :");
            Console.WriteLine();
            foreach (var v in graph.GetVertexLists(vertex))
            {

                Console.WriteLine($"{v.Number} : {v.Name} ");
            }
        }
        public static Vertex GetChosenVertex(Graph graph, Vertex vertex, int  key_for_choice)
        {
            
            foreach (var v in graph.GetVertexLists(vertex))
            {
                if (v.Number == key_for_choice)
                    return v;
            }
            return vertex;

        }

    }
}
