using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    abstract class Network
    {
        protected int numberOfInputs;
        protected int numberOfLayers;
        protected Layer[] layers;
        protected double[][] output;

        public int NumberOfInputs
        {
            get { return numberOfInputs; }
        }

        public int NumberOfLayers
        {
            get { return numberOfLayers; }
        }

        public double[][] Output
        {
            get { return output; }
        }

        public Layer this[int index]
        {
            get { return layers[index]; }
        }

        protected Network(int numberOfInputs, int numberOfLayers)
        {
            this.numberOfInputs = Math.Max(1, numberOfInputs);
            this.numberOfLayers = Math.Max(1, numberOfLayers);

            layers = new Layer[this.numberOfLayers];
        }

        public virtual double[][] Compute(double[] input)
        {
            output = new double[layers.Length][];
            output[0] = input;

            for (int i = 1; i < layers.Length; i++)
            {
                output[i] = layers[i].Compute(output[i - 1]);
            }

            return output;
        }

        public virtual void SetInitialWeights(double min, double max)
        {
            foreach (Layer layer in layers)
            {
                layer.SetInitialWeights(min, max);
            }
        }
    }
}
