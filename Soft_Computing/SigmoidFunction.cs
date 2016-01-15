using System;

namespace Soft_Computing
{
    public class SigmoidFunction
    {
        //                1
        // f(x) = ------------------
        //        1 + exp(-beta * x)
        //
        //           beta * exp(-beta * x )
        // f'(x) = ---------------------------- = beta * f(x) * (1 - f(x))
        //           (1 + exp(-beta * x))^2

        private double beta = 1.0;

        public double Beta
        {
            get { return beta; }
            set { beta = value; }
        }

        public SigmoidFunction() { }

        public SigmoidFunction(double beta)
        {
            this.beta = beta;
        }

        public double Function(double x)
        {
            return (1.0 / (1.0 + Math.Exp((-beta) * x)));
        }

        public double Derivative(double x)
        {
            double y = Function(x);

            return (beta * y * (1.0 - y));
        }
    }
}
