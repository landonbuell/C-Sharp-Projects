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
        // Init Variables
        public int layerNumber;
        public string layerName;
        public double[,] weights;
        public double[] biases;

        public Layer(int num, string name, double[,] W , double[] b)
        {
            // Constructor for Layer Parent Class Object
            this.layerNumber = num;
            this.layerName = name;
            this.weights = W;
            this.biases = b;
        }
    }


}
