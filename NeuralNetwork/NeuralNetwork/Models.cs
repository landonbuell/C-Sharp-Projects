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

namespace NeuralNetwork
{
    namespace Models
    {

        class BaseModel
        {
            // Parent Model Class Type
            public string modelName;
            public string modelType;
            public List<BaseLayer> modelLayers;
            public int modelDepth;


            protected List<BaseLayer> GetLayers()
            {
                return modelLayers;
            }

            protected void AddLayer (BaseLayer newLayer)
            {
                // Add New Layer to Model Layer Stack
                if (modelDepth == 0) && (newLayer.) 

            }
            
        }



        class FeedForward : BaseModel
        {
            // Standard Sequential or Feed-Forward Model

            private FeedForward (string name) : base(name)
            {
                // Constructor Method for Feed-Forward-Model
            }
        }


    }
}
