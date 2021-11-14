using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_first_project
{
    class Vertex
    {
        public int Number { get ; set; }
        

        public string Name { get; set; }
        public Vertex(int number, string name)
        {
            Number = number;
            Name = name;
        }

        //public override string ToString()
        //{
        //    return Number.ToString();
        //}

    }
}
