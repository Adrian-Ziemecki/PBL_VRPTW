using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Computing
{
    public partial class SGAForm : Form
    {
        public SGAForm()
        {
            InitializeComponent();
        }

        private void minRangeNUD_ValueChanged(object sender, EventArgs e)
        {
            double minRange = (double)minRangeNUD.Value;
            double maxRange = (double)maxRangeNUD.Value;

            if (minRange > maxRange)
            {
                maxRangeNUD.Value = Convert.ToDecimal(minRange);
            }
        }

        private void maxRangeNUD_ValueChanged(object sender, EventArgs e)
        {
            double minRange = (double)minRangeNUD.Value;
            double maxRange = (double)maxRangeNUD.Value;

            if (minRange > maxRange)
            {
                minRangeNUD.Value = Convert.ToDecimal(maxRange);
            }
        }

        private void mutationProbNUD_ValueChanged(object sender, EventArgs e)
        {
            int newMutProb = (int)murationProbNUD.Value;
            int curCrosProb = (int)crossingProbNUD.Value;

            int reproProb = 100 - newMutProb - curCrosProb;
            if (reproProb < 0)
            {
                curCrosProb -= reproProb;
            }
        }

        private void crossingProbNUD_ValueChanged(object sender, EventArgs e)
        {
            int newCrosProb = (int)crossingProbNUD.Value;
            int curMutProb = (int)murationProbNUD.Value;

            int reproProb = 100 - newCrosProb - curMutProb;
            if (reproProb < 0)
            {
                curMutProb -= reproProb;
            }
        }

        private void findSolutionBtn_Click(object sender, EventArgs e)
        {
            int populationSize = (int)populationSizeNUD.Value;
            int generations = (int)numberOfAttemptsNUD.Value;

            double stopValue = (double)stopValueNUD.Value;
            int stopGenerations = (int)stopGenerationsNUD.Value;

            int crosProb = (int)crossingProbNUD.Value;
            int mutProb = (int)murationProbNUD.Value;

            double minRange = (double)minRangeNUD.Value;
            double maxRange = (double)maxRangeNUD.Value;
            double range = maxRange - minRange;
            
            int precision = (int)precisionNUD.Value;
            int bitSize = Convert.ToInt32(Math.Ceiling(Math.Log((range * Math.Pow(10.0, (double)precision)), 2.0)));

            System.Diagnostics.Debug.Write("bitSize: " + bitSize.ToString() + "\n");

            SGASolutionFinder solutionFinder = new SGASolutionFinder(minRange, maxRange, bitSize, precision, crosProb, mutProb, populationSize, generations, stopValue, stopGenerations);
            solutionFinder.BeginSelection();

            solutionsLV.Items.Clear();
            bestFitLV.Items.Clear();

            ListViewItem solutionsItem = null;
            for (int i = 0; i < generations; i++)
            {
                for (int j = 0; j < populationSize; j++)
                {
                    double solution = solutionFinder.Solutions[i][j].ChromosomeToDouble() / Math.Pow(10.0, precision);
                    solutionsItem = solutionsLV.Items.Add(string.Format("{0}", i + 1));
                    solutionsItem.SubItems.Add(solution.ToString());
                    solutionsItem.SubItems.Add(solutionFinder.Fitness[i][j].ToString());
                }
            }

            ListViewItem bestFitItem = null;
            for (int i = 0; i < generations; i++)
            {
                double bestFit = solutionFinder.BestFit[i];
                double bestFitOutput = solutionFinder.FitnessFunction(bestFit);
                bestFitItem = bestFitLV.Items.Add(string.Format("{0}", i + 1));
                bestFitItem.SubItems.Add(bestFit.ToString());
                bestFitItem.SubItems.Add(bestFitOutput.ToString());
            }
        }
    }
}
