/*
 * Landon Buell
 * Neural Network
 * Layer Objects
 * 8 September 2020
 */

using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Models;
using NeuralNetwork.MathematicalUtilities;

namespace NeuralNetwork
{
    namespace Layers
    {

        public class BaseLayer
        {
            // Parent Layer Class Type
            public string layerName;
            public string layerType;
            public int layerNumber;

            protected BaseActivationFunction ActFunc;
            protected double[,] W;
            protected double[,] b;

            protected BaseLayer(string name, BaseActivationFunction actFunc)
            {
                // Constructor Method for BaseLayer Object
                this.layerName = name;
                this.ActFunc = actFunc;
            }

            protected BaseLayer(string name)
            {
                // Constructor Method for BaseLayer Object
                this.layerName = name;
                this.ActFunc = IdentityActivationFunction();
            }

            public int[,] InputShape { get; set; }

            public int[,] OutputShape { get; set; }

            public int[,] WeightShape { get; set; }

            public int[,] BiasShape { get; set; }

            public double[,] Call(double[,] X)
            {
                // Call Layer w/ Input X
                return X;
            }

            
            
            
        }

        public class InputLayer : BaseLayer
        {
            // Input Layer Object

            private InputLayer(string name, int[,] shape) : base(name)
            {
                // Constructor Method for Input Layer 
                this.layerType = "Input";
                this.layerNumber = 0;
                InputShape = shape;
                OutputShape = shape;
            }

            public override double[,] Call (double[,] X)
            {
                // Call Input Layer Object
                return X;
            }

        }

        public class DenseLayer : BaseLayer
        {
            // Standard Dense Layer
            private int neurons;

            private DenseLayer(string name, int neurons) : base(name)
            {
                // Constructor Method for Dense layer
                this.layerType = "Dense";
                this.neurons = neurons;

            }
        }

        class ActivationLayer : BaseLayer
        {
            // Activation Function Layer
        }

    }
}
