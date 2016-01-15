using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class NeuronTraining
    {
        double[][] resultWeights;
        double[] resultErrors;

        public double[][] ResultWeights
        {
            get { return resultWeights; }
        }

        public double[] ResultErrors
        {
            get { return resultErrors; }
        }

        public NeuronTraining()
        {

        }

        public void RunTraining(ref IdentityNeuron neuron, ref NeuronTrainingPattern[] trainingSet, int inputNumber, double trainingStep, int epochs)
        {
            if (neuron == null || trainingSet == null || trainingSet.Count() < 0 || epochs < 1)
            {
                System.Diagnostics.Debug.Write("Warning: Attempting to run training without all parameters correctly set.");
                return;
            }

            int trainingNumber = trainingSet.Count();

            resultWeights = null;
            resultErrors = null;

            resultWeights = new double[epochs][];
            for (int i = 0; i < epochs; i++)
            {
                resultWeights[i] = new double[inputNumber];
            }
            resultErrors = new double[epochs];

            for (int i = 0; i < epochs; i++)
            {
                double error = runTrainingIteration(ref neuron, ref trainingSet, trainingStep, trainingNumber, inputNumber);

                resultErrors[i] = error;
                resultWeights[i] = neuron.Weights;
                //System.Diagnostics.Debug.Write("Weight after: " + i.ToString() + " epoch:" + resultWeights[i][0].ToString() + "\n");
                System.Diagnostics.Debug.Write("Errors after: " + i.ToString() + " epoch: " + resultErrors[i].ToString() +  "\n");
            }
        }

        private double runTrainingIteration(ref IdentityNeuron neuron, ref NeuronTrainingPattern[] trainingSet, double trainingStep, int trainingNumber, int inputNumber)
        {
            double finalError = 0.0;
            for (int i = 0; i < trainingNumber; i++)
            {
                double[] inputVectors = trainingSet[i].neuronInputVectors;
                double computedOutputVector = neuron.Compute(inputVectors);
                double error = trainingSet[i].neuronOutputVector - computedOutputVector;

                for (int j = 0; j < inputNumber; j++)
                {
                    neuron.Weights[j] = neuron.Weights[j] + trainingStep * error * inputVectors[j];
                }

                finalError += (error * error);
            }
            finalError /= trainingNumber;
            return finalError;
        }
    }
}
