using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Classes
{
    public class Neuron
    {
        private double[] weights;
        private double bias;

        public Neuron(int inputCount)
        {
            weights = new double[inputCount];
            RandomizeWeights();
            bias = 0;
        }

        public double FeedForward(double[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }
            sum += bias;
            return Sigmoid(sum);
        }

        private double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        private void RandomizeWeights()
        {
            Random rand = new Random();
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = rand.NextDouble() * 2 - 1;
            }
        }
    }

}
