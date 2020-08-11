/*
 * Landon Buell
 * Nueral Netork Test v0
 * Main Function
 * 29 July 2020
 */

using System;
using System.Numerics;

namespace Neural_Network_v0
{
    class Program
    {
        static void Main()
        {

            int batchSize = 32;
            int n_features = 4;
            int n_classes = 2;

            SequentialNetwork JARVIS = new SequentialNetwork("JARVIS");
            JARVIS.AddLayer(new InputLayer("In", new int[2] { n_features, batchSize }));
            JARVIS.AddLayer(new LinearDenseLayer("D1", 16));
            JARVIS.AddLayer(new LinearDenseLayer("Out", n_classes));
            JARVIS.AssembleModel(new StochasticGradientDescent());

            JARVIS.ModelSummary();
           
        }
    }
}
