/*
 * Landon Buell
 * Nueral Netork Test v0
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
        public int layerNumber;
        public string layerName;
        public string layerType;
        public Func<double[,]> activation;
        public int[] inputShape = new int[2];
        public int[] outputShape = new int[2];
        public double[,] weights;
        public double[,] biases;

        public void SetLayerNum(int layerNum)
        {
            // Set Layer Number Index
            this.layerNumber = layerNum;
        }

        public void SetInputShape(int[] shape)
        {
            // Set Input Shape of Layer Object
            this.inputShape = shape;
        }

    }

    public class InputLayer : Layer
    {
        public InputLayer(string name, int[] inShape)
        {
            // Constructor Method for InputLayer Object
            this.layerName = name;
            this.layerType = "Input Layer";
            this.inputShape = inShape;
            this.outputShape = inputShape;
        }

        public double[,] __call__(double[,] X )
        {
            // Call InputLayer of Network
            Debug.Assert(X.GetLength(0) == inputShape[0]);
            Debug.Assert(X.GetLength(1) == inputShape[1]);
            return X;
        }
    }

    public class LinearDenseLayer : Layer
    {
        private int _neurons;

        public LinearDenseLayer(string name, int neurons)
        {
            // Constructor Method for LinearDenseLayer
            this.layerName = name;
            this.layerType = "Linear Dense Layer";
            this._neurons = neurons;
        }

        public Double[,] __call__(double[,] X)
        {
            // Call LinearDenseLayer of network
            // Call InputLayer of Network
            Debug.Assert(X.GetLength(0) == inputShape[0]);
            Debug.Assert(X.GetLength(1) == inputShape[1]);
            double[,] Y = new double[2,2];
            return Y;
        }
    }



}
