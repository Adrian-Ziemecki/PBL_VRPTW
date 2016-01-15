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
    public partial class NeuronForm : Form
    {
        NeuronTrainingSet trainingSet;
        double[][] inputSet;
        IdentityNeuron neuron;
        NeuronTraining neuronTraining;
        int numberOfInputs = 0;
        int trainingPatternNumber = 0;
        bool trained = false;
        bool trainingSetLoaded = false;

        public NeuronForm()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = Application.StartupPath;
            neuronTraining = new NeuronTraining();
        }

        private void trainingSetBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader file = File.OpenText(openFileDialog.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    trainingSet = (NeuronTrainingSet)serializer.Deserialize(file, typeof(NeuronTrainingSet));
                }
                if (trainingSet.trainingPatterns != null)
                {
                    trainingSetLoaded = true;
                    numberOfInputs = trainingSet.trainingPatterns[0].neuronInputVectors.Count();
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
            trainingSetLV.Columns.Add("Output", 50, HorizontalAlignment.Left);

            // add items
            for (int i = 0; i < trainingPatternNumber; i++)
            {
                trainingSetLV.Items.Add(trainingSet.trainingPatterns[i].neuronInputVectors[0].ToString());

                for (int j = 1; j < numberOfInputs; j++)
                {
                    trainingSetLV.Items[i].SubItems.Add(trainingSet.trainingPatterns[i].neuronInputVectors[j].ToString());
                }
                trainingSetLV.Items[i].SubItems.Add(trainingSet.trainingPatterns[i].neuronOutputVector.ToString());
            }
        }

        private void trainNeuronBtn_Click(object sender, EventArgs e)
        {
            neuron = new IdentityNeuron(numberOfInputs);
            int epochs = int.Parse(epochsTB.Text);
            double trainingStep = double.Parse(trainingStepTB.Text);
            neuronTraining.RunTraining(ref neuron, ref trainingSet.trainingPatterns, numberOfInputs, trainingStep, epochs);

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
            for (int j = 0; j < numberOfInputs; j++)
            {
                item = trainingOutputLV.Items.Add(string.Format("{0}", j + 1));
                item.SubItems.Add(neuron.Weights[j].ToString());
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
                computationOutputLV.Columns.Add("Output", 50, HorizontalAlignment.Left);

                // add inputs to items
                for (int i = 0, n = inputSet.Count(); i < n; i++)
                {
                    computationOutputLV.Items.Add(inputSet[i][0].ToString());

                    for (int j = 1; j < numberOfInputs; j++)
                    {
                        computationOutputLV.Items[i].SubItems.Add(inputSet[i][j].ToString());
                    }
                }

                double sum = 0.0;
                for (int i = 0, n = inputSet.Count(); i < n; i++)
                {
                    sum = neuron.Compute(inputSet[i]);

                    computationOutputLV.Items[i].SubItems.Add(sum.ToString());
                }
            }
        }
    }
}
