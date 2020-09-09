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

        class BaseLayer
        {
            // Parent Layer Class Type
            public string layerName;
            public string layerType;
            public int layerNumber;
            public int[,] inputShape;
            public int[,] outputShape;

            protected int[,] weightShape;
            protected int[,] biasShape;

            protected BaseActivationFunction ActFunc;
            protected double[,] W;
            protected double[,] b;

            protected BaseLayer(string name)
            {
                // Constructor Method for BaseLayer Object
                this.layerName = name;
            }

            protected double[,] Call(double[,] X)
            {
                // Call Layer w/ Input X
                return X;
            }

            
            
        }

        class InputLayer : BaseLayer
        {
            // Input Layer Object

            private InputLayer(string name, int[,] shape) : base(name)
            {
                // Constructor Method for Input Layer 
                this.layerType = "Input";
                this.layerNumber = 0;
                this.inputShape = shape;
            }

        }

        class DenseLayer : BaseLayer
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
