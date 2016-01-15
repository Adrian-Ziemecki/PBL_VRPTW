namespace Soft_Computing
{
    struct NeuronTrainingSet
    {
        public NeuronTrainingPattern[] trainingPatterns;
    }
    struct NeuronTrainingPattern
    {
        public double[] neuronInputVectors;
        public double neuronOutputVector;
    }

    struct PerceptronTrainingSet
    {
        public PerceptronTrainingPattern[] trainingPatterns;
    }
    struct PerceptronTrainingPattern
    {
        public double[] perceptronInputVectors;
        public double[] perceptronOutputVectors;
    }
}