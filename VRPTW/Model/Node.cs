using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPTW.Model
{
    public class Node
    {
        public int CustomerNr { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Demand { get; set; }
        public int ReadyTime { get; set; }
        public int DueDate { get; set; }
        public int Service { get; set; }        
        public List<int> Connections { get; set; }

        public Node()
        {
            Connections = new List<int>();
        }
    }
}
