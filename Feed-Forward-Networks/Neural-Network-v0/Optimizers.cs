using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Neural_Network_v0
{
    public class Optimizer
    {
        // Parent Class , All Optimizers Inherit from

        public Optimizer()
        {
            // Default Constructor Method for Optimizer Class
            LearningRate = 0.9;
        }

        public Optimizer(double rate)
        {
            // Constructor Method for Optimizer Class   
            LearningRate = rate;
        }

        public string OptimizerName
        {
            // get or Set Optimizer Method Name
            get; set;
        }

        public double LearningRate
        {
            // Get or Set the Optimizer Learning Rate
            get; set;
        }

        public void BackPropagate(List<Layer> modelLayers)
        {
            // Backward - Propagate through Layers Sequential Network Model
      
        }
    }

    public class StochasticGradientDescent : Optimizer
    {
        public StochasticGradientDescent()
        {
            // Default Constructor for Stochastic Gradient Descent Class
            OptimizerName = "Stochastic Gradient Descent";
        }

        public StochasticGradientDescent (double rate) : base(rate)
        {
            // Constructor Method for Stochastic Gradient Descent Class
            OptimizerName = "Stochastic Gradient Descent";
        }

    }
}
