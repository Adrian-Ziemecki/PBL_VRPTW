using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPTW.Model;

namespace VRPTW.Controller
{
    class GAController
    {
        private GARouletteController geneticRoulette;

        public int PopulationSize;
        public int Generations;
        public List<Chromosome> Solutions;

        public int CrossProb
        {
            get { return geneticRoulette.CrossProb; }
            set { geneticRoulette.CrossProb = value; }
        }
        public int MutProb
        {
            get { return geneticRoulette.MutProb; }
            set { geneticRoulette.MutProb = value; }
        }

        public GAController(int populationSize = 50, int generations = 100)
        {
            this.PopulationSize = populationSize;
            this.Generations = generations;
            this.Solutions = new List<Chromosome>(this.PopulationSize);
            this.geneticRoulette = new GARouletteController();
        }

        public void RunSimulation(Map map)
        {
            // Get number of clients on the map (without depo)
            int numberOfClients = map.Locations.Count - 1;
            // Get max possible value based on due date of depo
            Double maxValue = Convert.ToDouble(map.Locations.First().DueDate);
            // Set min possible value as 1.0 - impossible to achieve, but not illegal.
            Double minValue = 1.0;
            // Generate random initial chromosomes
            for (int i = 0; i < PopulationSize; i++)
            {
                /*Solutions[i] = new Chromosome(numberOfClients);
                do
                {
                    Solutions[i].MakeRandomChromosome();
                    Solutions[i].FitnessFunction(map);
                } while (Solutions[i].Fitness < 0);*/
                Chromosome c = new Chromosome(numberOfClients);
                do
                {
                    c.MakeRandomChromosome();
                    c.Fitness = c.FitnessFunction(map);
                } while (c.Fitness < 0);
                Solutions.Add(c);
            }

            for (int i = 0; i < Generations; i++)
            {
                Solutions = geneticRoulette.createNewGeneration(Solutions, maxValue, minValue, map);
                if (checkStopConditions() == true) break;
                Chromosome ch = GetBestSolutionFound();
                Console.WriteLine("best " + ch.FitnessFunction(map) + ", routes " + ch.Routes.Count());
            }
        }

        private bool checkStopConditions()
        {
            // Currently empty
            return false;
        }

        public void PrintSolutions()
        {
            foreach (Chromosome c in Solutions) {
                System.Console.WriteLine(c.ChromosomeString());
            }
        }

        public string GetSolutionText()
        {
            string s = "";
            foreach (Chromosome c in Solutions)
            {
                s = s + c.ChromosomeString() + "\r\n";
            }
            return s;
        }

        public Chromosome GetBestSolutionFound()
        {
            if (Solutions.Count == 0)
            {
                throw new System.InvalidOperationException("Cannot find best solution, none currently exist.");
            }

            Chromosome bestFit = Solutions[0];

            foreach (Chromosome chromosome in Solutions)
            {
                if (chromosome.Fitness > bestFit.Fitness) bestFit = chromosome;
            }

            return bestFit;
        }
    }
}
