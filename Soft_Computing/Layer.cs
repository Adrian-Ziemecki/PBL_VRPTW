using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    abstract class Layer
    {
        protected int numberOfInputs = 0;
        protected int numberOfNeurons = 0;
        protected Neuron[] neurons;
        protected double[] output;

        public int NumberOfInputs
        {
            get { return numberOfInputs; }
        }

        public int NumberOfNeurons
        {
            get { return numberOfNeurons; }
        }

        public double[] Output
        {
            get { return output; }
        }

        public Neuron this[int index]
        {
            get { return neurons[index]; }
        }

        protected Layer(int numberOfNeurons, int numberOfInputs)
        {
            this.numberOfInputs = numberOfInputs;
            this.numberOfNeurons = numberOfNeurons;

            neurons = new Neuron[this.numberOfNeurons];
            output = new double[this.numberOfNeurons];
        }

        public virtual double[] Compute(double[] input)
        {
            // compute each neuron
            for (int i = 0; i < numberOfNeurons; i++)
                output[i] = neurons[i].Compute(input);

            return output;
        }

        public virtual void SetInitialWeights(double min, double max)
        {
            foreach (Neuron neuron in neurons)
            {
                neuron.SetInitialWeights(min, max);
            }
        }
    }
}
