/*
 * Landon Buell
 * Neural Network
 * Main Executable
 * 8 September 2020
 */

using System;

using NeuralNetwork.Models;
using NeuralNetwork.Layers;
using NeuralNetwork.ActivationFunctions;
using NeuralNetwork.Optimizers;
using NeuralNetwork.Losses;
using NeuralNetwork.MathematicalUtilities;


namespace NeuralNetwork
{
    class NeuralNetworkMain
    {
        static void Main(string[] args)
        {
            FeedForward JARVIS = new FeedForward("JARVIS");

            JARVIS.AddLayer(new InputLayer("Input", new int[] { 4 , 1 }));
            JARVIS.AddLayer(new DenseLayer("Dense1", new Identity(), 8));
            JARVIS.AddLayer(new DenseLayer("Dense2", new Identity(), 6));
            JARVIS.AddLayer(new DenseLayer("Output", new Identity(), 2));

            JARVIS.CompileModel();
            JARVIS.ShowSummary();
        }
    }
}
