using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class IdentityNeuron:Neuron
    {
        public IdentityNeuron(int numberOfInputs) : base(numberOfInputs)
        {

        }
        override public double Compute(double[] input)
        {
            double sum = 0.0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                sum += weights[i] * input[i];
            }

            return sum;
        }
    }
}
