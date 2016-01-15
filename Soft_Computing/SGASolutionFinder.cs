using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class SGASolutionFinder
    {
        protected static Random rand = new Random((int)DateTime.Now.Ticks);

        private SGAChromosome[][] solutions;
        private double[][] fitness;
        private double[] overallFitness;
        private double[] bestFit;
        private double minRange;
        private double maxRange;
        private int bitSize;
        private int crosProb;
        private int mutProb;
        private int populationSize;
        private int generations;
        private double stopCritValue;
        private int stopCritRange;
        private double precisionDenominator;

        public SGAChromosome[][] Solutions
        {
            get { return solutions; }
        }

        public double[][] Fitness
        {
            get { return fitness; }
        }

        public double[] BestFit
        {
            get { return bestFit; }
        }

        public SGASolutionFinder(double minRange, double maxRange, int bitSize, int precision, int crosProb, int mutProb, int populationSize, int generations, double stopCritValue, int stopCritRange)
        {
            this.minRange = minRange;
            this.maxRange = maxRange;
            this.bitSize = bitSize;
            this.crosProb = crosProb;
            this.mutProb = mutProb;
            this.populationSize = populationSize;
            this.generations = generations;
            this.stopCritValue = stopCritValue;
            this.stopCritRange = stopCritRange;
            this.precisionDenominator = Math.Pow(10, precision);
            this.overallFitness = new double[generations];
            this.bestFit = new double[generations];

            this.solutions = new SGAChromosome[generations][];
            for (int i = 0; i < generations; i++)
            {
                solutions[i] = new SGAChromosome[populationSize];
                for (int j = 0; j < populationSize; j++)
                {
                    solutions[i][j] = new SGAChromosome(bitSize);
                }
            }

            this.fitness = new double[generations][];
            for (int i = 0; i < generations; i++)
            {
                fitness[i] = new double[populationSize];
            }
        }

        public void BeginSelection()
        {
            for (int i = 0; i < populationSize; i++)
            {
                double x = 0;
                do
                {
                    solutions[0][i].GenerateRandomChromosome();
                    x = minRange + (solutions[0][i].ChromosomeToDouble() / precisionDenominator);
                }
                while ((((solutions[0][i].ChromosomeToDouble() / precisionDenominator) + (double)minRange) > (double)maxRange) || (FitnessFunction(x) <= 0));
            }

            for (int i = 0; i < generations; i++)
            {
                fitGeneration(i);
                getBestFit(i);
                createNewGeneration(i);
                if (checkStopConditions(i)) return;
            }
        }

        private bool checkStopConditions(int currentGen)
        {
            if (currentGen < stopCritRange) return false;
            double[] averageFitness = new double[stopCritRange];
            double averageDifference = 0;
            for (int i = 0; i < stopCritRange; i++)
            {
                averageFitness[i] += overallFitness[currentGen - stopCritRange + i] / (double)populationSize;
            }
            for (int i = 1; i < stopCritRange; i++)
            {
                averageDifference += Math.Abs(averageFitness[i] - averageFitness[i - 1]);
            }
            averageDifference /= ((double)stopCritRange - 1.0);

            if (averageDifference <= stopCritValue) return true;
            else return false;
        }

        private void getBestFit(int currentGen)
        {
            double bestFit = minRange + (solutions[currentGen][0].ChromosomeToDouble() / precisionDenominator);

            for (int i = 1; i < populationSize; i++)
            {
                double x = minRange + (solutions[currentGen][i].ChromosomeToDouble() / precisionDenominator);
                if (FitnessFunction(x) > FitnessFunction(bestFit))
                {
                    bestFit = x;
                }
            }

            this.bestFit[currentGen] = bestFit;
        }

        private void fitGeneration(int currentGen)
        {
            for (int i = 0; i < populationSize; i++)
            {
                double x = minRange + (solutions[currentGen][i].ChromosomeToDouble() / precisionDenominator);
                fitness[currentGen][i] = FitnessFunction(x);
                overallFitness[currentGen] += fitness[currentGen][i];
            }
        }

        private void createNewGeneration(int currentGen)
        {
            if (currentGen >= generations - 1) return;

            double[] selectionProb = new double[populationSize];
            for (int i = 0; i < populationSize; i++)
            {
                selectionProb[i] = fitness[currentGen][i] / overallFitness[currentGen];
            }

            double[] distribution = new double[populationSize];
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
                if ((randomGenetic <= crosProb) && (i + 1 < populationSize))
                {
                    geneticOperation = 1;
                }
                else if (randomGenetic <= (crosProb + mutProb))
                {
                    geneticOperation = 2;
                }

                switch (geneticOperation)
                {
                    case 0:
                        int reproductionChromosome = selectChromosome(distribution);
                        reproduce(reproductionChromosome, i, currentGen);
                        break;
                    case 1:
                        int parent1 = selectChromosome(distribution);
                        int parent2 = selectChromosome(distribution);
                        while (parent1 == parent2)
                        {
                            parent2 = selectChromosome(distribution);
                        }
                        cross(parent1, parent2, i, currentGen);
                        i++;
                        break;
                    case 2:
                        int mutationChromosome = selectChromosome(distribution);
                        mutate(mutationChromosome, i, currentGen);
                        break;
                }
            }

            for (int i = 0; i < populationSize; i++)
            {
                double x = minRange + (solutions[currentGen + 1][i].ChromosomeToDouble() / precisionDenominator);
                while ((((solutions[currentGen + 1][i].ChromosomeToDouble() / precisionDenominator) + (double)minRange) > (double)maxRange) || (FitnessFunction(x) <= 0))
                {
                    solutions[currentGen + 1][i].GenerateRandomChromosome();
                    x = minRange + (solutions[currentGen + 1][i].ChromosomeToDouble() / precisionDenominator);
                }
            }
        }

        public double FitnessFunction(double x)
        {
            double sin = Math.Sin(10.0 * Math.PI * x);
            double numerator = Math.Pow(Math.E, x) * sin + 1.0;
            double denominator = x + 5.0;
            return (numerator/denominator);
        }

        private int selectChromosome(double[] distribution)
        {
            double randomSelection = rand.NextDouble();
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

        private void reproduce(int chromosomeIndex, int popIndex, int currentGen)
        {
            solutions[currentGen + 1][popIndex].CreateChromosomeFromReproduction(solutions[currentGen][chromosomeIndex]);
        }

        private void mutate(int chromosomeIndex, int popIndex, int currentGen)
        {
            solutions[currentGen + 1][popIndex].CreateChromosomeFromMutation(solutions[currentGen][chromosomeIndex]);
        }

        private void cross(int parent1Index, int parent2Index, int popIndex, int currentGen)
        {
            solutions[currentGen + 1][popIndex].CreateChromosomeFromCrossing(solutions[currentGen][parent1Index], solutions[currentGen][parent2Index]);
            solutions[currentGen + 1][popIndex + 1].CreateChromosomeFromCrossing(solutions[currentGen][parent2Index], solutions[currentGen][parent1Index]);
        }
    }
}
