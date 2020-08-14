using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using NeuralNetworkv0.Layers;
using NeuralNetworkv0.Models;
using NeuralNetworkv0.Initializers;

namespace NeuralNetworkv0
{

    namespace Optimizers
    {
        public class BaseOptimizer
        {
            // Parent Class , All Optimizers Inherit from

            public BaseOptimizer()
            {
                // Default Constructor Method for Optimizer Class
                LearningRate = 0.9;
            }

            public BaseOptimizer(double rate)
            {
                // Constructor Method for Optimizer Class   
                LearningRate = rate;
            }

            public string OptimizerName { get; set; }

            public double LearningRate { get; set; }

            public void BackPropagate(List<Layers.BaseLayer> modelLayers)
            {
                // Backward - Propagate through Layers Sequential Network Model

            }
        }

        public class StochasticGradientDescent : BaseOptimizer
        {
            public StochasticGradientDescent()
            {
                // Default Constructor for Stochastic Gradient Descent Class
                OptimizerName = "Stochastic Gradient Descent";
            }

            public StochasticGradientDescent(double rate) : base(rate)
            {
                // Constructor Method for Stochastic Gradient Descent Class
                OptimizerName = "Stochastic Gradient Descent";
            }

        }
    }
}
