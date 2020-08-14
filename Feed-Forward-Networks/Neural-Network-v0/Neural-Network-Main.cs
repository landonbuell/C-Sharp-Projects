/*
 * Landon Buell
 * Nueral Netork Test v0
 * Main Function
 * 29 July 2020
 */

using System;
using System.Numerics;

using NeuralNetworkv0.Layers;
using NeuralNetworkv0.ActivationFunctions;
using NeuralNetworkv0.Models;
using NeuralNetworkv0.Optimizers;
using NeuralNetworkv0.Initializers;

namespace NeuralNetworkv0
{
    class Program
    {
        static void Main()
        {

            int batchSize = 32;
            int n_features = 4;
            int n_classes = 2;

            Models.SequentialNetwork JARVIS = new Models.SequentialNetwork("JARVIS");

            JARVIS.AddLayer(new InputLayer("In", n_features, batchSize));
            JARVIS.AddLayer(new LinearDenseLayer("D1", 16, new ReLU() ));
            JARVIS.AddLayer(new LinearDenseLayer("D2", 32, new ReLU() ));
            JARVIS.AddLayer(new LinearDenseLayer("D3", 16, new ReLU() ));
            JARVIS.AddLayer(new LinearDenseLayer("Out", n_classes, new Softmax() ));

            JARVIS.ModelSummary();

           
           
        }
    }
}
