using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPTW.Model
{
    public class Chromosome
    {
        public int[] Route { get; set; }
        protected static Random rand = new Random((int)DateTime.Now.Ticks);
        protected static Double mutationRate = 0.1;

        public Chromosome(int numberOfCustomerNodes)
        {
            Route = new int[numberOfCustomerNodes];
        }

        // Order Crossover
        public void CrossChromosomeWithParents(Chromosome Parent1, Chromosome Parent2)
        {
            clearRoute();
            // Randomly get the part of Parent1 that will be transferred to Child
            int start = rand.Next(Route.Length);
            int end = rand.Next(start, Route.Length);
            
            // Copy selected part of Parent1 to Child
            for (int i = start; i <= end; i++)
            {
                Route[i] = Parent1.Route[i];
            }

            // Sweep Parent2 circularly and copy remaining nodes
            int childIndex = (end + 1 == Route.Length) ? 0 : end + 1;
            int parentIndex = childIndex;
            while (childIndex != start)
            {
                bool assignedNode = false;
                int parentStartingIndex = parentIndex;
                do
                {
                    int parentNode = Parent2.Route[parentIndex];
                    if (isNodePresent(parentNode))
                    {
                        parentIndex = (parentIndex + 1 == Route.Length) ? 0 : parentIndex + 1;
                        // Check to avoid infinite loop.
                        // Generally, if it gets here, then the whole chromosome will get messed up anyway.
                        if (parentIndex == parentStartingIndex)
                        {
                            Route[childIndex] = -1;
                            assignedNode = true;
                        }
                    }
                    else
                    {
                        Route[childIndex] = parentNode;
                        assignedNode = true;
                    }
                } while (!assignedNode);
                childIndex = (childIndex + 1 == Route.Length) ? 0 : childIndex + 1;
            }
        }

        public void MakeRandomChromosome() 
        {
            // Generate a list of ints from 0 to Route.Count
            List<int> nums = new List<int>();
            for (int i = 0; i < Route.Length; i++)
            {
                nums.Add(i);
            }
            // Add a random element from list of ints and remove this element from list (so there won't be duplicates)
            for (int i = 0; i < Route.Length; i++)
            {
                int r = rand.Next(0, nums.Count);
                Route[i] = nums[r];
                nums.RemoveAt(r);
            }
        }

        public void MutateChromosome()
        {
            Double chance = rand.NextDouble();
            int temp1, temp2, rand1, rand2;
            List<int> RouteList;
            if (chance < mutationRate)
            {
                // the mutation will take place, mutation type is the same as in PDF
                int mutationType = rand.Next(1, 9);
                switch (mutationType)
                {
                    case 1:
                        rand1 = rand.Next(0, Route.Length - 2);
                        temp1 = Route[rand1];
                        Route[rand1] = Route[rand1 + 1];
                        Route[rand1 + 1] = temp1;
                        break;
                    case 2:
                        RouteList = Route.ToList<int>();
                        rand1 = rand.Next(0, RouteList.Count - 2);
                        rand2 = rand.Next(0, RouteList.Count - 2);
                        while (rand1 != rand2) rand2 = rand.Next(0, Route.Length - 2);  // make sure that rand1 and rand2 are different
                        temp1 = RouteList[rand1];
                        temp2 = RouteList[rand1 + 1];
                        RouteList.RemoveAt(rand1);
                        RouteList.RemoveAt(rand1 + 1);
                        RouteList.Insert(rand2, temp1);
                        RouteList.Insert(rand2 + 1, temp2);
                        Route = RouteList.ToArray<int>();
                        break;
                    case 3:
                        RouteList = Route.ToList<int>();
                        rand1 = rand.Next(0, RouteList.Count - 2);
                        rand2 = rand.Next(0, RouteList.Count - 2);
                        while (rand1 != rand2) rand2 = rand.Next(0, Route.Length - 2);  // make sure that rand1 and rand2 are different
                        temp1 = RouteList[rand1];
                        temp2 = RouteList[rand1 + 1];
                        RouteList.RemoveAt(rand1);
                        RouteList.RemoveAt(rand1 + 1);
                        RouteList.Insert(rand2, temp2);
                        RouteList.Insert(rand2 + 1, temp1);
                        Route = RouteList.ToArray<int>();
                        break;
                    case 4:
                        rand1 = rand.Next(0, Route.Length - 1);
                        rand2 = rand.Next(0, Route.Length - 1);
                        while (rand1 != rand2) rand2 = rand.Next(0, Route.Length - 1);  // make sure that rand1 and rand2 are different
                        temp1 = Route[rand1];
                        Route[rand1] = Route[rand2];
                        Route[rand2] = temp1;
                        break;
                    case 5:
                        rand1 = rand.Next(0, Route.Length - 2);
                        rand2 = rand.Next(0, Route.Length - 2);
                        while (rand1 != rand2) rand2 = rand.Next(0, Route.Length - 2);  // make sure that rand1 and rand2 are different
                        RouteList = Route.ToList<int>();
                        temp1 = RouteList[rand1];
                        RouteList[rand1] = RouteList[rand2];
                        RouteList.Insert(rand1 + 1, RouteList[rand2 + 1]);
                        RouteList[rand2 + 1] = temp1;
                        RouteList.RemoveAt(rand2 + 2);
                        Route = RouteList.ToArray<int>();
                        break;
                    case 6:
                        rand1 = rand.Next(0, Route.Length - 2);
                        rand2 = rand.Next(0, Route.Length - 2);
                        while (rand1 != rand2) rand2 = rand.Next(0, Route.Length - 2);  // make sure that rand1 and rand2 are different
                        temp1 = Route[rand1];
                        temp2 = Route[rand1 + 1];
                        Route[rand1] = Route[rand2];
                        Route[rand1 + 1] = Route[rand2 + 1];
                        Route[rand2] = temp1;
                        Route[rand2 + 1] = temp2;
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
            if (Route.Length == 0) return "{}";

            String chromosome = "{";
            foreach (int node in Route)
            {
                chromosome += node.ToString() + ",";
            }
            chromosome.Remove(chromosome.Length - 1);
            chromosome += "}";

            return chromosome;
        }

        private void clearRoute()
        {
            for (int i = 0; i < Route.Length; i++)
            {
                Route[i] = 0;
            }
        }

        private bool isNodePresent(int nodeToCheck)
        {
            foreach (int node in Route)
            {
                if (node == nodeToCheck) return true;
            }

            return false;
        }
    }
}
