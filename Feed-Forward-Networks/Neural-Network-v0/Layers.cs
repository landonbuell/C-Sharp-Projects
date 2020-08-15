/*
 * Landon Buell
 * Neural Netork Test v0
 * Layer Objects
 * 29 July 2020
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

using NeuralNetworkv0.Models;
using NeuralNetworkv0.Optimizers;
using NeuralNetworkv0.Initializers;
using NeuralNetworkv0.ActivationFunctions;
using System.Runtime.CompilerServices;

namespace NeuralNetworkv0
{

    namespace Layers
    {
        public class BaseLayer
        {
            // Init Variables for Layer Parent Class
            public int[] _weightShape;
            public int[] _biasShape;
            private double[,] _weights;
            private double[,] _biases;

            public BaseLayer(string name)
            {
                // Constructor Method for Layer Parent Class
                LayerName = name;
                LayerType = "Base Layer";
                InputShape = new int[2] { 0, 0 };
                OutputShape = new int[2] { 0, 0 };
                Activation = new Identity(OutputShape);
            }

            public BaseLayer(string name, BaseActivationFunction actFunc)
            {
                // Constructor Method for Layer Parent Class w/ Activation
                LayerName = name;
                LayerType = "Base Layer";
                InputShape = new int[2] { 0, 0 };
                OutputShape = new int[2] { 0, 0 };
                Activation = actFunc;
                Activation.ActivationShape = OutputShape;
            }

            public int LayerNumber { get; set; }

            public string LayerName { get; set; }

            public string LayerType { get; set; }

            public int[] InputShape { get; set; }

            public int[] OutputShape { get; set; }

            public BaseActivationFunction Activation { get; set; }

            public double[,] Weights
            {
                // Get or Set weight matrix elements
                get { return this._weights; }
                set
                {
                    // Ensure Dimensions Match Before setting Input
                    Debug.Assert(value.GetLength(0) == OutputShape[0]);
                    Debug.Assert(value.GetLength(1) == InputShape[0]);
                    this._weights = value;
                }
            }

            public double[,] Biases
            {
                // Get or Set weight matrix elements
                get { return this._biases; }
                set
                {
                    // Ensure Dimensions Match Before setting Input
                    Debug.Assert(value.GetLength(0) == OutputShape[0]);
                    Debug.Assert(value.GetLength(1) == 1);
                    this._biases = value;
                }
            }

            public void IntializeLayerParams()
            {
                // Initialize Layer Parameters Before When Model is Assemled

            }

            public double[,] CallLayer(double[,] X)
            {
                // Call Layer w/ Input X
                return X;
            }

        }

        public class InputLayer : BaseLayer
        {
            public InputLayer(string name, int features , int batchSize=1) : base(name)
            {
                // Constructor Method for InputLayer Object
                LayerType = "Input Layer";
                InputShape = new int[] { features, batchSize };
                OutputShape = InputShape;
            }

            public InputLayer(string name, int features, 
                BaseActivationFunction actFunc,int batchSize = 1) : base(name,actFunc)
            {
                // Constructor Method for InputLayer Object
                LayerType = "Input Layer";
                InputShape = new int[] { features, batchSize };
                OutputShape = InputShape;
            }

            public new double[,] CallLayer(double[,] X)
            {
                // Call Layer w/ Input X
                Debug.Assert(X.GetLength(0) == InputShape[0]);
                Debug.Assert(X.GetLength(1) == InputShape[1]);
                double[,] Y = Activation.CallFunc(X);
                return Y;
            }
        }

        public class LinearDenseLayer : BaseLayer
        {

            public LinearDenseLayer(string name, int neurons) : base(name)
            {
                // Constructor Method for Linear Dense Layer
                LayerType = "Linear Dense Layer";
                Neurons = neurons;
                OutputShape = new int[2] { Neurons, InputShape[1] };
            }

            public LinearDenseLayer(string name, int neurons, 
                BaseActivationFunction actFunc) : base(name,actFunc)
            {
                // Constructor Method for Linear Dense Layer
                LayerType = "Linear Dense Layer";
                Neurons = neurons;
                OutputShape = new int[2] { Neurons, InputShape[1] };
            }

            public int Neurons { get; set; }

            public new double[,] CallLayer (double[,] X)
            {
                // Call LinearDenseLayer of network
                Debug.Assert(X.GetLength(0) == InputShape[0]);
                Debug.Assert(X.GetLength(1) == InputShape[1]);
                double[,] _W = LinearAlgebra.MatrixMultiply(Weights, X);
                double[,] _b = LinearAlgebra.ExpandColumn(Biases, OutputShape[1]);
                double[,] _linearActivation = LinearAlgebra.MatrixAdd(_W, _b);
                double[,] Y = Activation.Call(_linearActivation);
                return Y;
            }
        }

        public class QuadraticDenseLayer : BaseLayer
        {

            private double[,] _weights2;

            public QuadraticDenseLayer(string name, int neurons) : base(name)
            {
                // Constructor Method for Quadratic Dense Layer
                LayerType = "Linear Dense Layer";
                Neurons = neurons;
            }

            public QuadraticDenseLayer(string name, int neurons,
                BaseActivationFunction actFunc) : base(name,actFunc)
            {
                // Constructor Method for Quadratic Dense Layer
                LayerType = "Linear Dense Layer";
                Neurons = neurons;
            }


            public int Neurons { get; set; }

        }

        public class ActivationLayer : BaseLayer
        {
            public ActivationLayer(string name, BaseActivationFunction actFunc) : base(name,actFunc)
            {
                // Constructor Method for Activation Layer Class
                LayerType = "Activation Function Layer";
            }

            public new double[,] CallLayer (double[,] X)
            {
                // Call Activation Layer of network
                Debug.Assert(X.GetLength(0) == InputShape[0]);
                Debug.Assert(X.GetLength(1) == InputShape[1]);
                double[,] Y = Activation.Call(X);
                return Y;
            }
        }
    }
}
