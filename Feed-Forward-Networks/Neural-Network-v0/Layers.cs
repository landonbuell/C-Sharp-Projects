/*
 * Landon Buell
 * Nueral Netork Test v0
 * Layer Objects
 * 29 July 2020
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Network_v0
{
    public class Layer
    {
        // Init Variables for Layer Parent Class
        public int layerNumber;
        public string layerName;
        public string layerType;
        public ActivationFunction activation;
        public int[,] inputShape;
        public int[,] outputShape;
        public double[,] weights;
        public double[,] biases;

        public void SetLayerNum(int layerNum)
        {
            // Set Layer Number Index
            this.layerNumber = layerNum;
        }

        public void SetInputShape(int[,] shape)
        {
            // Set Input Shape of Layer Object
            this.inputShape = shape;
        }

    }

    public class InputLayer : Layer
    {
        public InputLayer(string name, int[,] inShape)
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
            return X;
        }
    }

    public class LinearDenseLayer : Layer
    {
        public LinearDenseLayer(string name)
        {
            // Constructor Method for LinearDenseLayer
            this.layerName = name;
            this.layerType = "Linear Dense Layer";
        }

        public Double[,] __call__()
        {
            // Call LinearDenseLayer of network
            double[,] Y = new double[2,2];
            return Y;
        }
    }



}
