using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class SigmoidLayer: Layer
    {
        public new SigmoidNeuron this[int index]
        {
            get { return (SigmoidNeuron)neurons[index]; }
        }

        public SigmoidLayer(int numberOfNeurons, int numberOfInputs, SigmoidFunction function, double minInitialWeight, double maxInitialWeight, bool biased)
            : base(numberOfNeurons, numberOfInputs)
        {
            for (int i = 0; i < numberOfNeurons; i++)
            {
                neurons[i] = new SigmoidNeuron(numberOfInputs, function, minInitialWeight, maxInitialWeight, biased);
            }
        }
    }
}
