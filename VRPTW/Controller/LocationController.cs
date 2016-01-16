using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPTW.Model;

namespace VRPTW.Controller
{
    public class LocationController
    {
        public double DistanceBetweenLocations(Node location1, Node location2)
        {
            return Math.Sqrt(Math.Pow((location2.X - location1.X), 2) + Math.Pow((location2.Y - location1.Y), 2));
        }
    }
}
