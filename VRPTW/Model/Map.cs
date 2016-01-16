using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPTW.Model
{
    public class Map
    {
        public List<Node> Locations { get; set; }
        public int NumberOfVehicles { get; set; }
        public int VehicleCapacity { get; set; }

        public Map()
        {
            Locations = new List<Node>();   
        }
    }
}
