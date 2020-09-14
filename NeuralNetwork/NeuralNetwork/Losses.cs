using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.MathematicalUtilities;

namespace NeuralNetwork
{
    namespace Losses
    {
        class BaseLoss
        {
            // Parent Loss Function Class
            
            public string lossType = "Parent";

            protected void CallLoss (double[,] X, int[,] Y)
            {
                // Evaluate Loss Function
                

            }
        }

        class CategoricalCrossentropy : BaseLoss
        {
            public CategoricalCrossentropy() : base()
            {
                // Constructor for Categorical Crossentropy Loss Function
                this.lossType = "Categorical-Crossentropy";
            }

            public new double[,] CallLoss(double[,]X , int[,] Y)
            {
                // Evaluate Loss Function
                return X;
            }
        }

    }
}
