using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class InputLayer: Layer
    {
        public new InputNeuron this[int index]
        {
            get { return (InputNeuron)neurons[index]; }
        }

        public InputLayer(int numberOfInputs)
            : base(numberOfInputs, 1)
        {
            for (int i = 0; i < numberOfNeurons; i++)
            {
                neurons[i] = new InputNeuron(1);
            }
        }

        override public double[] Compute(double[] input)
        {
            // compute each neuron
            for (int i = 0; i < numberOfNeurons; i++)
            {
                InputNeuron neuron = (InputNeuron)neurons[i];
                output[i] = neuron.Compute(input[i]);
            }

            return output;
        }
    }
}
