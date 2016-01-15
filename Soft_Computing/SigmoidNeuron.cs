using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class SigmoidNeuron:Neuron
    {
        protected SigmoidFunction function = null;
        protected double sum = 0.0;
        protected bool biased = false;
        protected double biasedWeight = 0.0;

        public SigmoidFunction Function
        {
            get { return function; }
        }

        public double Sum
        {
            get { return sum; }
        }

        public bool Biased
        {
            get { return biased; }
        }

        public double BiasedWeight
        {
            get { return biasedWeight; }
            set { this.biasedWeight = value; }
        }

        public SigmoidNeuron(int numberOfInputs, SigmoidFunction function, double minInitialWeight, double maxInitialWeight, bool biased) : base(numberOfInputs)
        {
            this.function = function;
            this.SetInitialWeights(minInitialWeight, maxInitialWeight);
            this.biased = biased;
            if (this.biased) biasedWeight = rand.NextDouble() * (maxInitialWeight - minInitialWeight) + minInitialWeight;
        }

        override public double Compute(double[] input)
        {
            sum = 0.0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                sum += weights[i] * input[i];
            }
            if (biased) sum += biasedWeight * 1.0;
            return (output = function.Function(sum));
        }
    }
}
