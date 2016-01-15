using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Soft_Computing
{
    public partial class PerceptronForm : Form
    {
        PerceptronTrainingSet trainingSet;
        double[][] inputSet;
        PerceptronNetwork perceptronNetwork;
        PerceptronTraining perceptronTraining;
        int numberOfInputs = 0;
        int trainingPatternNumber = 0;
        bool trained = false;
        bool trainingSetLoaded = false;

        public PerceptronForm()
        {
            InitializeComponent();
        }

        private void trainingSetBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader file = File.OpenText(openFileDialog.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    trainingSet = (PerceptronTrainingSet)serializer.Deserialize(file, typeof(PerceptronTrainingSet));
                }
                if (trainingSet.trainingPatterns != null)
                {
                    trainingSetLoaded = true;
                    numberOfInputs = trainingSet.trainingPatterns[0].perceptronInputVectors.Count();
                    trainingPatternNumber = trainingSet.trainingPatterns.Count();
                }
                else
                {
                    trainingSetLoaded = false;
                    numberOfInputs = 0;
                    trainingPatternNumber = 0;
                }
                trained = false;
                trainNeuronBtn.Enabled = trainingSetLoaded;
                computeBtn.Enabled = trained;
                updateTrainingSetList();

            }
        }

        private void updateTrainingSetList()
        {
            trainingSetLV.Items.Clear();
            trainingSetLV.Columns.Clear();
            trainingOutputLV.Items.Clear();

            if (!trainingSetLoaded)
            {
                return;
            }

            // add columns
            for (int i = 0; i < numberOfInputs; i++)
            {
                trainingSetLV.Columns.Add(string.Format("Input {0}", i + 1),
                    50, HorizontalAlignment.Left);
            }
            for (int i = 0; i < numberOfInputs; i++)
            {
                trainingSetLV.Columns.Add(string.Format("Output {0}", i + 1),
                    50, HorizontalAlignment.Left);
            }

            // add items
            for (int i = 0; i < trainingPatternNumber; i++)
            {
                trainingSetLV.Items.Add(trainingSet.trainingPatterns[i].perceptronInputVectors[0].ToString());

                for (int j = 1; j < numberOfInputs; j++)
                {
                    trainingSetLV.Items[i].SubItems.Add(trainingSet.trainingPatterns[i].perceptronInputVectors[j].ToString());
                }
                for (int j = 0; j < numberOfInputs; j++)
                {
                    trainingSetLV.Items[i].SubItems.Add(trainingSet.trainingPatterns[i].perceptronOutputVectors[j].ToString());
                }
            }
        }

        private void trainNeuronBtn_Click(object sender, EventArgs e)
        {
            if (perceptronNetwork != null) perceptronNetwork = null;
            SigmoidFunction sigmoidFunction = new SigmoidFunction();
            int[] numberOfNeurons = {numberOfInputs, int.Parse(hiddenNeuronsTB.Text), numberOfInputs};
            bool biased = biasedChkBox.Checked;
            perceptronNetwork = new PerceptronNetwork(sigmoidFunction, numberOfInputs, -0.5, 0.5, biased, numberOfNeurons);
            perceptronTraining = new PerceptronTraining(ref perceptronNetwork);
            int epochs = int.Parse(epochsTB.Text);
            double trainingStep = double.Parse(trainingStepTB.Text);
            perceptronTraining.TrainingStep = trainingStep;
            perceptronTraining.RunTraining(ref trainingSet, epochs);

            trained = true;
            computeBtn.Enabled = trained;
            updateTrainingOutputList();
        }

        private void updateTrainingOutputList()
        {
            trainingOutputLV.Items.Clear();

            if (!trained)
            {
                return;
            }

            ListViewItem item = null;
            // add all weights
            for (int i = 1, n = perceptronNetwork.NumberOfLayers; i < n; i++)
            {
                for (int j = 0, m = perceptronNetwork[i].NumberOfNeurons; j < m; j++)
                {
                    for (int k = 0, o = perceptronNetwork[i][j].NumberOfInputs; k < o; k++)
                    {
                        item = trainingOutputLV.Items.Add(string.Format("{0}, {1}, {2}", i, j + 1, k + 1));
                        item.SubItems.Add(perceptronNetwork[i][j].Weights[k].ToString());
                    }
                }
            }
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader file = File.OpenText(openFileDialog.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    inputSet = (double[][])serializer.Deserialize(file, typeof(double[][]));
                }


                computationOutputLV.Items.Clear();
                computationOutputLV.Columns.Clear();

                // add columns
                for (int i = 0; i < numberOfInputs; i++)
                {
                    computationOutputLV.Columns.Add(string.Format("Input {0}", i + 1),
                        50, HorizontalAlignment.Left);
                }

                for (int i = 0, n = perceptronNetwork.NumberOfLayers; i < n; i++)
                {
                    for (int j = 0, m = perceptronNetwork[i].NumberOfNeurons; j < m; j++)
                    {
                        computationOutputLV.Columns.Add(string.Format("Out {0}, {1}", i, j + 1));
                    }
                }

                // add inputs and outputs to items
                for (int i = 0, n = inputSet.Count(); i < n; i++)
                {
                    computationOutputLV.Items.Add(inputSet[i][0].ToString());

                    for (int j = 1; j < numberOfInputs; j++)
                    {
                        computationOutputLV.Items[i].SubItems.Add(inputSet[i][j].ToString());
                    }
                    double[][] sum = perceptronNetwork.Compute(inputSet[i]);
                    for (int j = 0, m = perceptronNetwork.NumberOfLayers; j < m; j++)
                    {
                        for (int k = 0, o = perceptronNetwork[j].NumberOfNeurons; k < o; k++)
                        {
                            computationOutputLV.Items[i].SubItems.Add(sum[j][k].ToString());
                        }
                    }
                }
            }
        }
    }
}
