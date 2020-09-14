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
using NeuralNetwork.ActivationFunctions;
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

            public BaseActivationFunction actFunc;
            public double[,] W;
            public double[,] b;

            public BaseLayer(string name, BaseActivationFunction actFunc)
            {
                // Constructor Method for BaseLayer Object
                this.layerName = name;
                this.actFunc = actFunc;
            }

            public int[] InputShape { get; set; }

            public int[] OutputShape { get; set; }

            public int[] WeightShape { get; set; }

            public int[] BiasShape { get; set; }

            public void InitLayer()
            {
                // Initialize Layer, Generate Needed Shapes & Arrays
                
            }


            public double[,] GenerateWeights()
            {
                // Generate Weighting Matrix
                throw new NotImplementedException();
            }

            public double[,] GenerateBiases()
            {
                // Generate Bias Vector
                throw new NotImplementedException();
            }

            public double[,] CallLayer (double[,] X)
            {
                // Call Layer w/ Input X
                return X;
            }    
        }

        public class InputLayer : BaseLayer
        {
            // Input Layer Object

            public InputLayer(string name, int[] shape) : base(name,new Identity())
            {
                // Constructor Method for Input Layer 
                this.layerType = "Input-Layer";
                this.layerNumber = 0;
                InputShape = shape;
                OutputShape = shape;

            }

        }

        public class DenseLayer : BaseLayer
        {
            // Standard Dense Layer
            private int neurons;

            public DenseLayer(string name, BaseActivationFunction actFunc, int neurons ) : base(name,actFunc)
            {
                // Constructor Method for Dense layer
                this.layerType = "Dense-Layer";
                this.neurons = neurons;
            }

            public new void InitLayer()
            {
                // Initialize Layer, Generate Needed Shapes & Arrays
                WeightShape = new int[] { neurons, InputShape[0] };
                BiasShape = new int[] { neurons, 1 };
                OutputShape = new int[] { neurons, 1 };
            }

            public new double[,] CallLayer (double[,] X)
            {
                // Call Dense Layer w/ Input X
                return LinearAlgebra.MatrixProduct(W, X);
            }
        }

        public class ActivationLayer : BaseLayer
        {
            // Activation Function Layer

            public ActivationLayer(string name, BaseActivationFunction actFunc) : base(name, actFunc)
            {
                // Constructor for Activation Layer
                this.layerType = "Activation-Layer";
                               
            }
        }
    }
}
