using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class PerceptronTraining
    {
        private PerceptronNetwork network;
        private double trainingStep = 0.1;

        public double TrainingStep
        {
            get { return trainingStep; }
            set
            {
                trainingStep = Math.Max(0.0, Math.Min(1.0, value));
            }
        }

        public PerceptronTraining(ref PerceptronNetwork network)
        {
            this.network = network;
        }

        public double Run(double[] input, double[] output)
        {
            double[][] networkOutput = network.Compute(input);

            double error = 0.0;

            for (int i = network.NumberOfLayers - 1; i > 0; i--)
            {
                SigmoidLayer layer = (SigmoidLayer)network[i];
                Layer previousLayer = null;
                bool lastLayer = (i == network.NumberOfLayers - 1);
                
                // Get previous layer if current layer is not the output layer
                if (!lastLayer) previousLayer = network[i + 1];

                for (int j = 0; j < layer.NumberOfNeurons; j++)
                {
                    double e = 0.0;
                    SigmoidNeuron neuron = layer[j];
                    double derivative = neuron.Function.Derivative(neuron.Sum);

                    if (lastLayer)
                    {
                        // Error calculation for last layer
                        e = derivative * (output[j] - neuron.Output);
                    }
                    else
                    {
                        // Error calculation for hidden layer(s)
                        double sumOfPreviousLayerErrors = 0.0;
                        for (int k = 0; k < previousLayer.NumberOfNeurons; k++)
                        {
                            Neuron previousLayerNeuron = previousLayer[k];
                            sumOfPreviousLayerErrors += previousLayerNeuron.Weights[j] * previousLayerNeuron.Error;
                        }
                        e = derivative * sumOfPreviousLayerErrors;
                    }

                    neuron.Error = e;
                    
                    error += neuron.Error;
                }
     
            }
            // Update weights
            for (int i = 1; i < network.NumberOfLayers; i++)
            {
                SigmoidLayer layer = (SigmoidLayer)network[i];

                for (int j = 0; j < layer.NumberOfNeurons; j++)
                {
                    SigmoidNeuron neuron = layer[j];
                    for (int k = 0; k < neuron.NumberOfInputs; k++)
                    {
                        neuron.Weights[k] = neuron.Weights[k] + trainingStep * neuron.Error * networkOutput[i - 1][k];
                    }
                    if (neuron.Biased) neuron.BiasedWeight = neuron.BiasedWeight + trainingStep * neuron.Error;
                }
            }

            return error;
        }

        public double RunEpoch(PerceptronTrainingPattern[] trainingPatterns)
        {
            double error = 0.0;

            // run learning procedure for all samples
            for (int i = 0, n = trainingPatterns.Length; i < n; i++)
            {
                error += Run(trainingPatterns[i].perceptronInputVectors, trainingPatterns[i].perceptronOutputVectors);
            }

            // return summary error
            return error;
        }

        public void RunTraining(ref PerceptronTrainingSet trainingSet, int numberOfEpochs)
        {
            double error = 0.0;
            for (int i = 0; i < numberOfEpochs; i++)
            {
                error = RunEpoch(trainingSet.trainingPatterns);
                //System.Diagnostics.Debug.Write("Summary error after " + (i+1).ToString() + " epoch: " + error.ToString() + "\n");
            }
        }
    }
}
