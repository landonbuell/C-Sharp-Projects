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
        public SequentialNetwork model;
        public double learningRate = 1;

        public Optimizer(SequentialNetwork network)
        {
            // Constructor Method for Optimizer Class
            this.model = network;
        }

        public Optimizer(SequentialNetwork network,double rate)
        {
            // Constructor Method for Optimizer Class
            this.model = network;
            this.learningRate = rate;
        }

        public void BackPropagate()
        {
            // Backward- Propagate through Sequential Network Model
      
        }
    }

    public class StochasticGradientDescent : Optimizer
    {
        public StochasticGradientDescent (SequentialNetwork network,double rate) :
            base(network,rate)
        {
            // Constructor Method for StochasticGradientDescent Class
            Optimizer Opt = new Optimizer(network, rate);
        }

    }
}
