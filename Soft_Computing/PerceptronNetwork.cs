using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    class PerceptronNetwork: Network
    {
        public new Layer this[int index]
        {
            get { return ((Layer)layers[index]); }
        }

        public PerceptronNetwork(SigmoidFunction function, int numberOfInputs, double minInitialWeight, double maxInitialWeight, bool biased, params int[] numberOfNeurons)
            : base(numberOfInputs, numberOfNeurons.Length)
        {
            layers[0] = new InputLayer(numberOfInputs);
            for (int i = 1; i < numberOfLayers; i++)
            {
                layers[i] = new SigmoidLayer(numberOfNeurons[i], numberOfNeurons[i - 1], function, minInitialWeight, maxInitialWeight, biased);
            }
        }
    }
}
