using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPTW.Controller;

namespace VRPTW.Model
{
    public class Chromosome
    {
        public int[] Nodes { get; set; }
        public List<int[]> Routes { get; set; }
        public Double Fitness;
        protected static Random rand = new Random((int)DateTime.Now.Ticks);
        protected static Double mutationRate = 1.0;
        private LocationController locationController = new LocationController();

        public Chromosome(int numberOfCustomerNodes)
        {
            Nodes = new int[numberOfCustomerNodes];
            Routes = new List<int[]>();
            Fitness = 0;
        }

        // Order Crossover
        public void CrossChromosomeWithParents(Chromosome Parent1, Chromosome Parent2, int startingNode, int endingNode)
        {
            clearRoute();
            // Randomly get the part of Parent1 that will be transferred to Child
            int start = startingNode;
            int end = endingNode;
            
            // Copy selected part of Parent1 to Child
            for (int i = start; i <= end; i++)
            {
                Nodes[i] = Parent1.Nodes[i];
            }

            // Sweep Parent2 circularly and copy remaining nodes
            int childIndex = (end + 1 == Nodes.Length) ? 0 : end + 1;
            int parentIndex = childIndex;
            while (childIndex != start)
            {
                bool assignedNode = false;
                int parentStartingIndex = parentIndex;
                do
                {
                    int parentNode = Parent2.Nodes[parentIndex];
                    if (isNodePresent(parentNode))
                    {
                        parentIndex = (parentIndex + 1 == Nodes.Length) ? 0 : parentIndex + 1;
                        // Check to avoid infinite loop.
                        // Generally, if it gets here, then the whole chromosome will get messed up anyway.
                        if (parentIndex == parentStartingIndex)
                        {
                            Nodes[childIndex] = -1;
                            assignedNode = true;
                        }
                    }
                    else
                    {
                        Nodes[childIndex] = parentNode;
                        assignedNode = true;
                    }
                } while (!assignedNode);
                childIndex = (childIndex + 1 == Nodes.Length) ? 0 : childIndex + 1;
            }
        }

        public void MakeRandomChromosome() 
        {
            // Generate a list of ints from 0 to Nodes.Count
            List<int> nums = new List<int>();
            for (int i = 0; i < Nodes.Length; i++)
            {
                nums.Add(i);
            }
            // Add a random element from list of ints and remove this element from list (so there won't be duplicates)
            for (int i = 0; i < Nodes.Length; i++)
            {
                int r = rand.Next(0, nums.Count);
                Nodes[i] = nums[r];
                nums.RemoveAt(r);
            }
        }

        public void MutateChromosome(int mutationType = 0)
        {
            Double chance = rand.NextDouble();
            int temp1, temp2, rand1, rand2;
            List<int> RouteList;
            if (chance < mutationRate)
            {
                // the mutation will take place, mutation type is the same as in PDF
                if (mutationType == 0) mutationType = rand.Next(1, 9);
                switch (mutationType)
                {
                    case 1:
                        rand1 = rand.Next(0, Nodes.Length - 2);
                        temp1 = Nodes[rand1];
                        Nodes[rand1] = Nodes[rand1 + 1];
                        Nodes[rand1 + 1] = temp1;
                        break;
                    case 2:
                        RouteList = Nodes.ToList<int>();
                        rand1 = rand.Next(0, RouteList.Count - 2);
                        rand2 = rand.Next(0, RouteList.Count - 2);
                        while (rand1 == rand2) rand2 = rand.Next(0, Nodes.Length - 2);  // make sure that rand1 and rand2 are different
                        temp1 = RouteList[rand1];
                        temp2 = RouteList[rand1 + 1];
                        RouteList.RemoveAt(rand1);
                        RouteList.RemoveAt(rand1);
                        RouteList.Insert(rand2, temp1);
                        RouteList.Insert(rand2 + 1, temp2);
                        Nodes = RouteList.ToArray<int>();
                        break;
                    case 3:
                        RouteList = Nodes.ToList<int>();
                        rand1 = rand.Next(0, RouteList.Count - 2);
                        rand2 = rand.Next(0, RouteList.Count - 2);
                        while (rand1 == rand2) rand2 = rand.Next(0, Nodes.Length - 2);  // make sure that rand1 and rand2 are different
                        temp1 = RouteList[rand1];
                        temp2 = RouteList[rand1 + 1];
                        RouteList.RemoveAt(rand1);
                        RouteList.RemoveAt(rand1);
                        RouteList.Insert(rand2, temp2);
                        RouteList.Insert(rand2 + 1, temp1);
                        Nodes = RouteList.ToArray<int>();
                        break;
                    case 4:
                        rand1 = rand.Next(0, Nodes.Length - 1);
                        rand2 = rand.Next(0, Nodes.Length - 1);
                        while (rand1 == rand2) rand2 = rand.Next(0, Nodes.Length - 1);  // make sure that rand1 and rand2 are different
                        temp1 = Nodes[rand1];
                        Nodes[rand1] = Nodes[rand2];
                        Nodes[rand2] = temp1;
                        break;
                    case 5:
                        rand1 = rand.Next(0, Nodes.Length - 2);
                        rand2 = rand.Next(0, Nodes.Length - 2);
                        while (rand1 == rand2) rand2 = rand.Next(0, Nodes.Length - 2);  // make sure that rand1 and rand2 are different
                        RouteList = Nodes.ToList<int>();
                        temp1 = RouteList[rand1];
                        RouteList[rand1] = RouteList[rand2];
                        RouteList.Insert(rand1 + 1, RouteList[rand2 + 1]);
                        RouteList[rand2 + 1] = temp1;
                        RouteList.RemoveAt(rand2 + 2);
                        Nodes = RouteList.ToArray<int>();
                        break;
                    case 6:
                        rand1 = rand.Next(0, Nodes.Length - 2);
                        rand2 = rand.Next(0, Nodes.Length - 2);
                        while (rand1 == rand2) rand2 = rand.Next(0, Nodes.Length - 2);  // make sure that rand1 and rand2 are different
                        temp1 = Nodes[rand1];
                        temp2 = Nodes[rand1 + 1];
                        Nodes[rand1] = Nodes[rand2];
                        Nodes[rand1 + 1] = Nodes[rand2 + 1];
                        Nodes[rand2] = temp1;
                        Nodes[rand2 + 1] = temp2;
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                }
            }
            else
            {
                // do nothing
            }
        }

        // Print chromosome route to readable form
        public String ChromosomeString()
        {
            if (Nodes.Length == 0) return "{}";

            String chromosome = "{";
            foreach (int node in Nodes)
            {
                chromosome += node.ToString() + ",";
            }
            chromosome.Remove(chromosome.Length - 1);
            chromosome += "}";

            return chromosome;
        }

        private void clearRoute()
        {
            for (int i = 0; i < Nodes.Length; i++)
            {
                Nodes[i] = 0;
            }
        }

        private bool isNodePresent(int nodeToCheck)
        {
            foreach (int node in Nodes)
            {
                if (node == nodeToCheck) return true;
            }

            return false;
        }

        public double fitnessFunction(Map map)
        {

            double currentTime = 0;
            double currentVehicleLoad = 0;
            double maxVehicleLoad = map.VehicleCapacity;
            int availableVehicles = map.NumberOfVehicles;
            int vehiclesUsed = 1;

            List<int> singleRoute = new List<int>();            
            Node depo = map.Locations.Where(l => l.CustomerNr == 0).Single();
            singleRoute.Add(depo.CustomerNr);
            Node previousNode = depo;

            Routes.Clear();

            for (int i = 0; i < Nodes.Length; i++)
            {
                Node currentNode = map.Locations.Where(l => l.CustomerNr == Nodes[i]).Single();

                if (vehiclesUsed > availableVehicles){ 
                    return -1; 
                }

                if(currentVehicleLoad + currentNode.Demand <= maxVehicleLoad)
                {
                    currentVehicleLoad += currentNode.Demand;
                    currentTime = locationController.DistanceBetweenLocations(previousNode, currentNode);
                    if (currentTime < currentNode.ReadyTime){ 
                        currentTime += (currentNode.ReadyTime - currentTime); 
                    }

                    if (currentTime + currentNode.Service < currentNode.DueDate)
                    {
                        currentTime += currentNode.Service;

                        if (currentTime + locationController.DistanceBetweenLocations(currentNode, depo) < depo.DueDate)
                        {
                            singleRoute.Add(currentNode.CustomerNr);
                            previousNode = currentNode;
                        }
                        else
                        {
                            singleRoute.Add(depo.CustomerNr);
                            Routes.Add(singleRoute.ToArray());
                            previousNode = depo;
                            currentTime = 0;
                            currentVehicleLoad = 0;
                            vehiclesUsed++;
                        }
                    }
                    else
                    {
                        singleRoute.Add(depo.CustomerNr);
                        Routes.Add(singleRoute.ToArray());
                        previousNode = depo;
                        currentTime = 0;
                        currentVehicleLoad = 0;
                        vehiclesUsed++;
                    }
                }
                
            }
            int visitedNodes = 0;
            foreach (int[] singleR in Routes)
            {
                foreach (int place in singleR)
                {
                    if (place != 0){ 
                        visitedNodes++; 
                    }
                }
            }

            if (visitedNodes == Nodes.Length)
            {
                double totalPath = 0;
                foreach (int[] singleR in Routes)
                {
                    for (int place = 1; place < singleR.Length; place++ )
                    {
                        Node place1 = map.Locations.Where(l => l.CustomerNr == singleR[place - 1]).Single();
                        Node place2 = map.Locations.Where(l => l.CustomerNr == singleR[place]).Single();
                        totalPath += locationController.DistanceBetweenLocations(place1, place2);
                    }
                }
                return totalPath;
            }
            else
            {
                return -1;
            }
        }
    }
}
