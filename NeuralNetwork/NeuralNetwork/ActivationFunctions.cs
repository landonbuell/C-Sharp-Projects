/*
 * Landon Buell
 * Neural Network
 * Layer Objects
 * 8 September 2020
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    namespace ActivationFunctions
    {
        public class BaseActivationFunction
        {
            // Parent Activation Function Class
            public string name = "Parent-Activation-Function";

            public int[] Shape { get; set; }

            public double[,] CallFunc(double[,] X)
            {
                // Call this Activation Function
                return X;
            }

            public double[,] CallDeriv(double[,] X)
            {
                // Call this Activation Function Derivative
                double[,] Y = new double[X.GetLength(0), X.GetLength(1)];
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                        Y[i, j] = 1.0;
                return Y;
            }

        }

        public class Identity : BaseActivationFunction
        {
            // Identity Activation Function

            
        }

        public class ReLU : BaseActivationFunction
        {
            // Rectified Linear Unit Activation Function 
            public new string name = "ReLU-Activation-Function";

            public new double[,] CallFunc (double[,] X)
            {
                // Call ReLU Activation Function
                double[,] Y = new double[X.GetLength(0), X.GetLength(1)];
                for (int i = 0; i < X.GetLength(0); i++)       
                    for (int j = 0; j < X.GetLength(1); j++)
                        Y[i, j] = Math.Max(0.0, X[i, j]);
                return Y;           
            }

            public new double[,] CallDeriv(double[,] X)
            {
                // Call Derivative of ReLU Activation Function
                // Call ReLU Activation Function
                double[,] Y = new double[X.GetLength(0), X.GetLength(1)];
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i, j] > 0.0)
                            Y[i, j] = 1.0;
                        else
                            Y[i, j] = 0.0;
                    }                       
                }                   
                return Y;
            }
        }

        public class Softmax : BaseActivationFunction
        {

        }


    }
}
