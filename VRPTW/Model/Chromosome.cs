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
            int temp;
            if (chance < mutationRate)
            {
                // the mutation will take place, mutation type is the same as in PDF
                int mutationType = rand.Next(1, 9);
                switch (mutationType)
                {
                    case 1:
                        int r = rand.Next(0, Route.Length - 2);
                        temp = Route[r];
                        Route[r] = Route[r + 1];
                        Route[r + 1] = r;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        int r1 = rand.Next(0, Route.Length - 1);
                        int r2 = rand.Next(0, Route.Length - 1);
                        while (r1 != r2)    // make sure that r1 and r2 are different
                        {
                            r2 = rand.Next(0, Route.Length - 1);
                        }
                        temp = Route[r1];
                        Route[r1] = Route[r2];
                        Route[r2] = temp;
                        break;
                    case 5:
                        break;
                    case 6:
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
