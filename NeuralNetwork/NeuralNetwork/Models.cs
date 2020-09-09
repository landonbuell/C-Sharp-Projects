/*
 * Landon Buell
 * Neural Network
 * Model Objects
 * 8 September 2020
 */

using System;
using System.Collections.Generic;
using System.Text;

using NeuralNetwork.Layers;
using NeuralNetwork.MathematicalUtilities;
using NeuralNetwork.Optimizers;
using NeuralNetwork.Losses;

namespace NeuralNetwork
{
    namespace Models
    {
        public class BaseModel
        {
            // Parent Model Class Type
            public string modelName;
            public string modelType;
            public List<BaseLayer> modelLayers;
            public int modelDepth;

            public BaseModel(string name)
            {
                // Constructor Method for Base Model parent Class
                this.modelName = name;
                this.modelType = "Parent";
                this.modelLayers = new List<BaseLayer>();
                this.modelDepth = modelLayers.Count;
            }

            protected List<BaseLayer> GetLayers()
            {
                return modelLayers;
            }

            protected void AddLayer (BaseLayer newLayer)
            {
                // Add New Layer to Model Layer Stack
                

            }

            protected List<BaseLayer> GetLayers()
            {
                // Get list of layers in order
                return modelLayers;
            }

            protected CompileModel()
            {
                // Compile
            }

        }



        public class FeedForward : BaseModel
        {
            // Standard Sequential or Feed-Forward Model

            private FeedForward (string name) : base(name)
            {
                // Constructor Method for Feed-Forward-Model
            }
        }


    }
}
