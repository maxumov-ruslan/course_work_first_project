using System;

namespace course_work_first_project
{
    class Map:Graph
    {
        protected Vertex current_location { get; set ; }
        
        protected Graph graph_1 = new Graph();
        public void Create_Map()
        {
            
            
            var v1 = new Vertex(1, "Пляж");
            var v2 = new Vertex(2, "Лес");
            var v3 = new Vertex(3, "Горы");
            var v4 = new Vertex(4, "Шахта");
            var v5 = new Vertex(5, "Маяк");

            {
                graph_1.AddVertex(v1);
                graph_1.AddVertex(v2);
                graph_1.AddVertex(v3);
                graph_1.AddVertex(v4);
                graph_1.AddVertex(v5);
            }
            
            {
                
                graph_1.AddEdge(v1, v2);
                graph_1.AddEdge(v1, v3);
                graph_1.AddEdge(v1, v4);

                
                graph_1.AddEdge(v2, v1);
                graph_1.AddEdge(v2, v3);

                
                graph_1.AddEdge(v3, v1);
                graph_1.AddEdge(v3, v2);
                graph_1.AddEdge(v3, v4);
                graph_1.AddEdge(v3, v5);

                
                graph_1.AddEdge(v4, v1);
                graph_1.AddEdge(v4, v3);
            }

            current_location = v1;
            
        }
        public void Start_Location()
        {
            PrintVertex(graph_1, current_location);
        }
        public void Select_Location(ConsoleKeyInfo keyInfo)
        {
            PrintVertex(graph_1, current_location);
            Console.Clear();
            int key = int.Parse(keyInfo.KeyChar.ToString());
            current_location = GetChosenVertex(graph_1, current_location, key);
   
        }

        public int Get_current_location()
        {
            return (current_location.Number);
        }
            
            
        
    }
}
