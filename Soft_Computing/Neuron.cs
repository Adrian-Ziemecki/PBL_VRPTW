using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Computing
{
    public abstract class Neuron
    {
        protected double[] weights = null;
        protected int numberOfInputs = 0;
        protected double output = 0;
        protected double error = 0;

        public double[] Weights
        {
            get { return weights; }
        }

        public int NumberOfInputs
        {
            get { return numberOfInputs; }
        }

        public double Output
        {
            get { return output; }
        }

        public double Error
        {
            get { return error; }
            set { error = value; }
        }

        public Neuron(int numberOfInputs)
        {
            this.numberOfInputs = Math.Max(1, numberOfInputs);
            weights = new double[this.numberOfInputs];
        }

        protected static Random rand = new Random((int)DateTime.Now.Ticks);

        public abstract double Compute(double[] input);

        public virtual void SetInitialWeights(double min, double max)
        {
            for (int i = 0; i < numberOfInputs; i++)
            {
                weights[i] = rand.NextDouble() * (max - min) + min;
            }
        }
    }
}
