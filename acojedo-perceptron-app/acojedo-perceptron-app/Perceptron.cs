using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace acojedo_perceptron_app
{
    internal class Perceptron
    {
        double[] weights;
        double bias;
        double learningRate = 1;
        int[][] inputs = new int[][] {
                     new int[] { 1,1,1,1,1,
                                 1,0,0,1,1,
                                 1,0,1,0,1,
                                 1,1,0,0,1,
                                 1,1,1,1,1},
                     new int[] { 1,1,1,0,0,
                                 0,0,1,0,0,
                                 0,0,1,0,0,
                                 0,0,1,0,0,
                                 1,1,1,1,1},
                     new int[] { 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1},
                     new int[] { 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1},
                     new int[] { 1,0,0,0,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 0,0,0,0,1},
                     new int[] { 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1},
                     new int[] { 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1},
                     new int[] { 1,1,1,1,1,
                                 0,0,0,1,0,
                                 0,0,1,0,0,
                                 0,1,0,0,0,
                                 1,0,0,0,0},
                     new int[] { 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1},
                     new int[] { 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1}
                     };
        int[] expectedOutputs = new int[10] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
        public Perceptron()
        {
            this.weights = new double[25];
            this.bias = 1;

            Random random = new Random();

            // Loop through the array and assign a random value to each element
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = random.NextDouble(); // Random integer between 0 and 1
            }
        }
        public double[] Train(int iepochs)
        {
            int epochs = 0;
            double totalError = 1;
            double y;
            double error;
            while (totalError > 0.2 && epochs < iepochs)
            {
                for(int i = 0; i < inputs.Length; i++)
                {
                    y = Predict(inputs[i]);
                    error = expectedOutputs[i] - y;
                    totalError += error;

                    for(int j = 0; j < weights.Length; j++)
                    {
                        weights[j] += error * inputs[i][j] * learningRate;
                    }
                    bias = learningRate * error;
                }
                epochs++;
                if(epochs % 1000 == 0)
                {
                    Console.WriteLine(totalError);
                }
            }
            return weights;
        }
        public int Predict(int[] input)
        {
            double sum = 0;

            for(int i = 0; i <  weights.Length; i++)
            {
                sum += weights[i] * input[i];
            }
            sum += bias;
            return sum >= 0 ? 1 : 0;
        }

        private void WeightReset()
        {
            Random random = new Random();

            // Loop through the array and assign a random value to each element
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = random.NextDouble(); // Random integer between 0 and 1
            }
        }
    }
}    
