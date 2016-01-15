using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class InputNeuron:Neuron
    {
        public InputNeuron(int numberOfInputs) : base(numberOfInputs)
        {

        }
        override public double Compute(double[] input)
        {
            return Compute(input[0]);
        }

        public double Compute(double input)
        {
            return output = input;
        }
    }
}
