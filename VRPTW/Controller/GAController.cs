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

        public void RunSimulation()
        {
            // Generate random initial chromosomes
            for (int i = 0; i < PopulationSize; i++)
            {
                Solutions[i] = new Chromosome(PopulationSize);
                do
                {
                    Solutions[i].MakeRandomChromosome();
                } while (Solutions[i].Fitness < 0);
            }

            for (int i = 0; i < PopulationSize; i++)
            {
                Solutions = geneticRoulette.createNewGeneration(Solutions);
                if (checkStopConditions() == true) break;
            }
        }

        private bool checkStopConditions()
        {
            // Currently empty
            return false;
        }
    }
}
