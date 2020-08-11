using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Neural_Network_v0
{
    class Intializers
    {
        // Parent Class used to intialize weights and biases
        private int[] arrayShape;
        protected string initializerType;

        public Intializers(int[] shape)
        {
            // Constructor Method for initializing layer weights
            this.arrayShape = shape;
            this.initializerType = "Parent";
           
        }

    }


    class GaussianIntializer : Intializers
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
