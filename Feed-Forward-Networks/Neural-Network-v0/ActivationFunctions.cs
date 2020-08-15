/*
 * Landon Buell
 * Nueral Netork Test v0
 * Activation functions
 * 29 July 2020
 */

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace NeuralNetworkv0
{

    namespace ActivationFunctions
    {
        public class BaseActivationFunction
        {
            // Parent Activation Functions Class
            public string functionName;

            public BaseActivationFunction()
            {
                // Base Constructor for Base Activation Function
                this.functionName = "Base";
            }

            public BaseActivationFunction(int [] shape)
            {
                // Base Constructor for Base Activation Function
                this.functionName = "Base";
                ActivationShape = shape;
            }   

            public int[] ActivationShape { get; set; }

            public double[,] CallFunc (double[,] X)
            {
                // Call Base Activation Function
                return X;
            }
        }

        public class Identity : BaseActivationFunction
        {           
            // Constructors for Identity Activation Function         
            public Identity () { functionName = "Identity"; }

            public Identity(int[] shape) : base(shape) { functionName = "Identity"; }

            public new double[,] CallFunc (double[,] X)
            {
                // Call Base Activation Function
                return X;
            }
        }


        public class ReLU : BaseActivationFunction
        {
            // Constructors for Rectified Linear Unit Activation Function         
            public ReLU() { functionName = "ReLU"; }

            public ReLU(int[] shape) : base(shape) { functionName = "ReLU"; }

            public new double[,] CallFunc(double[,] X)
            {
                // Call ReLU Activation Function
                return X;
            }
        }

        public class Softmax : BaseActivationFunction
        {
            // Constructors for Softmax Activation Function         
            public Softmax() { functionName = "Softmax"; }

            public Softmax(int[] shape) : base(shape) { functionName = "Softmax"; }

            public new double[,] CallFunc(double[,] X)
            {
                // Call Softmax Activation Function
                return X;
            }
        }



    } 
}
