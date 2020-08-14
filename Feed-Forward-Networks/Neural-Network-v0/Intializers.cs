using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using NeuralNetworkv0.Layers;
using NeuralNetworkv0.Models;
using NeuralNetworkv0.Optimizers;

namespace NeuralNetworkv0
{

    namespace Initializers
    {
        class BaseIntializer
        {
            // Parent Class used to intialize weights and biases
            private int[] _arrayShape;
            protected string initializerType;

            public BaseIntializer(int[] shape)
            {
                // Constructor Method for initializing layer weights
                this._arrayShape = shape;
                this.initializerType = "Parent";

            }
        }

        class GaussianIntializer : BaseIntializer
        {
            private float _mean = 0.0f;
            private float _var = 1.0f;

            public GaussianIntializer(int[] shape, float mean, float var) : base(shape)
            {
                // Constructor for Gaussian Weight/Bias Intializer
                this._mean = mean;
                this._var = var;
                this.initializerType = "Gaussian";
            }
        }
    } 
}
