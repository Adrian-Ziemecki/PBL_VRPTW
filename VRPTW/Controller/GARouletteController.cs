using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPTW.Model;

namespace VRPTW.Controller
{
    class GARouletteController
    {
        protected static Random rand = new Random((int)DateTime.Now.Ticks);

        private int crossProb;
        private int mutProb;

        // Set dynamic adjustment to new probability values, so that they never exceed 100%
        public int CrossProb
        {
            get
            {
                return crossProb;
            }
            set
            {
                if (value > 100) value = 100;
                else if (value < 0) value = 0;
                crossProb = value;
                if (crossProb + mutProb > 100) mutProb = 100 - crossProb;
            }
        }

        public int MutProb
        {
            get
            {
                return mutProb;
            }
            set
            {
                if (value > 100) value = 100;
                else if (value < 0) value = 0;
                mutProb = value;
                if (crossProb + mutProb > 100) crossProb = 100 - mutProb;
            }
        }

        // Constructor
        public GARouletteController(int crossProb = 34, int mutProb = 33)
        {
            this.CrossProb = crossProb;
            this.MutProb = mutProb;
        }

        public List<Chromosome> createNewGeneration(List<Chromosome> currentGeneration, Double maxValue, Double minValue, Map map)
        {
            int populationSize = currentGeneration.Count;
            int nodeSize = currentGeneration.First().Nodes.Length;
            Double[] selectionProb = new Double[populationSize];
            Double[] fitnessWithMaxMinValue = new Double[populationSize];
            List<Chromosome> newGeneration = new List<Chromosome>(populationSize);

            // Using the same loop for populating the new generation list and
            // calculating the fitness for minimum with resprect to maxValue
            for (int i = 0; i < populationSize; i++)
            {
                /*newGeneration[i] = new Chromosome(nodeSize);*/
                newGeneration.Add(new Chromosome(nodeSize));
                fitnessWithMaxMinValue[i] = maxValue + minValue - currentGeneration[i].Fitness;
            }

            // Get the overall fitness for modified fitness'
            Double overallFitness = getOverallFitness(fitnessWithMaxMinValue);

            // Calculating probabilities for each modified fitness
            for (int i = 0; i < populationSize; i++)
            {
                selectionProb[i] = fitnessWithMaxMinValue[i] / overallFitness;
            }

            // Computing the distribution for each chromosome
            Double[] distribution = new Double[populationSize];
            for (int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    distribution[i] += selectionProb[j];
                }
            }

            for (int i = 0; i < populationSize; i++)
            {
                // 0 - Reproduction
                // 1 - Crossing
                // 2 - Mutation
                int geneticOperation = 0;

                int randomGenetic = rand.Next(0, 100);
                if ((randomGenetic <= crossProb) && (i + 1 < populationSize))
                {
                    geneticOperation = 1;
                }
                else if (randomGenetic <= (crossProb + mutProb))
                {
                    geneticOperation = 2;
                }

                switch (geneticOperation)
                {
                    case 0:
                        int reproductionChromosome = selectChromosome(distribution, populationSize);
                        newGeneration[i] = currentGeneration[reproductionChromosome];
                        newGeneration[i].Fitness = newGeneration[i].FitnessFunction(map);
                        break;
                    case 1:
                        int parent1 = selectChromosome(distribution, populationSize);
                        int parent2 = selectChromosome(distribution, populationSize);
                        while (parent1 == parent2)
                        {
                            parent2 = selectChromosome(distribution, populationSize);
                        }
                        int startingIndex = rand.Next(nodeSize);
                        int endingIndex = rand.Next(startingIndex, nodeSize);
                        newGeneration[i].CrossChromosomeWithParents(currentGeneration[parent1], currentGeneration[parent2], startingIndex, endingIndex);
                        newGeneration[i].Fitness = newGeneration[i].FitnessFunction(map);
                        newGeneration[i + 1].CrossChromosomeWithParents(currentGeneration[parent2], currentGeneration[parent1], startingIndex, endingIndex);
                        newGeneration[i + 1].Fitness = newGeneration[i + 1].FitnessFunction(map);
                        i++;
                        break;
                    case 2:
                        int mutationChromosome = selectChromosome(distribution, populationSize);
                        newGeneration[i] = currentGeneration[mutationChromosome];
                        newGeneration[i].MutateChromosome();
                        newGeneration[i].Fitness = newGeneration[i].FitnessFunction(map);
                        break;
                }
            }

            // Make random chromosomes until there are no more failing solutions
            for (int i = 0; i < populationSize; i++)
            {
                while (newGeneration[i].Fitness < 0)
                {
                    newGeneration[i].MakeRandomChromosome();
                    newGeneration[i].Fitness = newGeneration[i].FitnessFunction(map);
                }
            }

            return newGeneration;
        }

        private Double getOverallFitness(Double[] currentGenerationFitness)
        {
            Double overallFitness = 0;

            foreach (Double fitness in currentGenerationFitness)
            {
                overallFitness += fitness;
            }

            return overallFitness;
        }

        private int selectChromosome(Double[] distribution, int populationSize)
        {
            Double randomSelection = rand.NextDouble();
            int selectedChromosome = populationSize - 1;
            for (int i = 0; i < populationSize; i++)
            {
                if (randomSelection <= distribution[i])
                {
                    selectedChromosome = i;
                    break;
                }
            }
            return selectedChromosome;
        }
    }
}