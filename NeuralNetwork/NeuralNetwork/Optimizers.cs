/*
 * Landon Buell
 * Neural Network
 * Optimizer Algorithms
 * 8 September 2020
 */

using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Models;
using NeuralNetwork.Layers;
using NeuralNetwork.MathematicalUtilities;

namespace NeuralNetwork
{
    namespace Optimizers
    {

        public class BaseOptimzier
        {
            // Parent Class For Optimzier Algorithms
            private BaseModel model;
            private double learningRate;

            public string optimizerName;

            public BaseOptimzier (BaseModel model, double LR)
            {
                // Constructor Method for Parent Optimzer
                this.model = model;
                this.learningRate = LR;
                this.optimizerName = "Parent";
            }

            

            protected void BackPropagate()
            {
                // Back Propagate Through Neural Network Model

            }

        }

        public class StochasticGradientDescent : BaseOptimzier
        {
            // Stochastic Gradient Descent Optimizer

            public StochasticGradientDescent (BaseModel model, double LR) : base(model, LR)
            {
                // Constructor For 
            }
        }

    }
}
