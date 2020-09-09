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

        class BaseOptimzier
        {
            // Parent Class For Optimzier Algorithms
            private BaseModel model;
            private double learningRate;

            public string optimizerName;

            private BaseOptimzier (BaseModel model, double LR)
            {
                // Constructor Method for Parent Optimzer
                this.model = model;
                this.learningRate = LR;
                this.optimizerName = "Parent";
            }

            private List<BaseLayer> GetModelLayers()
            {
                List<BaseLayer> = model.G
            }

            protected void BackPropagate()
            {
                // Back Propagate Through Neural Network Model

            }

        }

        class StochasticGradientDescent : BaseOptimzier
        {
            // Stochastic Gradient Descent Optimizer

            private StochasticGradientDescent (BaseModel model, double LR) : base(model, LR)
            {
                // Constructor For 
            }
        }

    }
}
