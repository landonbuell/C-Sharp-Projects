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

namespace Neural_Network_v0
{

    public class Layer
    {
        // Init Variables for Layer Parent Class
        private double[,] _weights;
        private double[,] _biases;
        protected string layerType;

        public Layer()
        {
            // Constructor Method for Layer Parent Class
            InputShape = new int[2] { 0, 0 };
            OutputShape = new int[2] { 0, 0 };
            this
        }

        public int LayerNumber
        {
            // Get or Set Layer Number Index
            get; set;
        }

        public string LayerName
        {
            // Get or Set Layer Name value
            get; set;
        }

        public string LayerType
        {
            // Get or Set the Layer Type
            get; set;
        }

        public int Neurons
        {
            // Get or Set the Number of Neurons in the Dense Layer
            get; set;
        }

        public int[] InputShape 
        {
            // Get or Set Input Shape of Layer Object
            get; set;
        }

        public int[] OutputShape
        {
            // Get or Set Input Shape of Layer Object
            get; set;
        }

        public Func<double[,]> Activation
        {
            // Get or Set Activation Function for Layer
            get; set;
        }

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

    }

    public class InputLayer : Layer
    {
        public InputLayer(string name, int[] inShape)
        {
            // Constructor Method for InputLayer Object
            LayerName = name;
            LayerType = "Input Layer";
            InputShape = inShape;
            OutputShape = inShape;

        }

        public double[,] __call__(double[,] X )
        {
            // Call InputLayer of Network
            Debug.Assert(X.GetLength(0) == InputShape[0]);
            Debug.Assert(X.GetLength(1) == InputShape[1]);
            return X;
        }
    }

    public class LinearDenseLayer : Layer
    {

        public LinearDenseLayer(string name, int neurons)
        {
            // Constructor Method for Linear Dense Layer
            LayerName = name;
            LayerType = "Linear Dense Layer";
            Neurons = neurons;
            OutputShape = new int[2] { Neurons, InputShape[1] };
        }

        public LinearDenseLayer(string name, int neurons, Func<double[,]> actFunc)
        {
            // Constructor Method for LinearDenseLayer
            LayerName = name;
            LayerType = "Linear Dense Layer";
            Neurons = neurons;
            OutputShape = new int[2] { Neurons, InputShape[1] };
            Activation = actFunc;
        }

        public double[,] __call__(double[,] X)
        {
            // Call LinearDenseLayer of network
            Debug.Assert(X.GetLength(0) == InputShape[0]);
            Debug.Assert(X.GetLength(1) == InputShape[1]);
            double[,] Y = new double[2,2];
            return Y;
        }
    }

    public class QuadraticDenseLayer : Layer
    {

        private double[,] _weights2;

        public QuadraticDenseLayer(string name, int neurons)
        {
            // Constructor Method for Quadratic Dense Layer
            LayerName = name;
            LayerType = "Linear Dense Layer";
            Neurons = neurons;
        }

        public QuadraticDenseLayer(string name, int neurons, Func<double[,]> actFunc)
        {
            // Constructor Method for LinearDenseLayer
            LayerName = name;
            LayerType = "Linear Dense Layer";
            Neurons = neurons;
            Activation = actFunc;
        }

        public double[,] __call__(double[,] X)
        {
            // Call LinearDenseLayer of network
            Debug.Assert(X.GetLength(0) == InputShape[0]);
            Debug.Assert(X.GetLength(1) == InputShape[1]);
            double[,] Y = new double[2, 2];
            return Y;
        }
    }

    public class ActivationLayer : Layer
    {
        public ActivationLayer(string name , Func<double[,]> actFunc)
        {
            // Constructor Method for Activation Layer Class
            LayerName = name;
            LayerType = "Activation Function Layer";
            Activation = actFunc;
        }

        public double[,] __call__(double[,] X)
        {
            // Call LinearDenseLayer of network
            Debug.Assert(X.GetLength(0) == InputShape[0]);
            Debug.Assert(X.GetLength(1) == InputShape[1]);
            double[,] Y = new double[2, 2];
            return Y;
        }
    }
}
