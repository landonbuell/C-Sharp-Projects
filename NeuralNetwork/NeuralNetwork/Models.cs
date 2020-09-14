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
            public int totalParams;

            public BaseModel(string name)
            {
                // Constructor Method for Base Model parent Class
                this.modelName = name;
                this.modelType = "Parent";
                this.modelLayers = new List<BaseLayer>();
                this.modelDepth = modelLayers.Count;
            }

            public void AddLayer (BaseLayer newLayer)
            {
                // Add New Layer to Model Layer Stack
                if ((modelDepth == 0) && (newLayer.layerType != "Input-Layer"))
                    throw new Exception();
                else
                {
                    modelLayers.Add(newLayer);
                    modelDepth += 1;
                }
            }

            public List<BaseLayer> GetLayers()
            {
                // Get list of layers in order
                return modelLayers;
            }

            public void CompileModel()
            {
                // Compile this Model - Set Params by layer

                for (int i = 1; i < modelDepth; i++)
                {
                    modelLayers[i].layerNumber = i;
                    // Determine Shapes of things
                    modelLayers[i].InputShape = modelLayers[i - 1].OutputShape;
                    modelLayers[i].InitLayer();
                }
            }

            public void ShowSummary()
            {
                Console.WriteLine("Model Name: {0} \nModel Type: {1} \nModel Depth: {2}", 
                    modelName,modelType,modelDepth);
                Console.WriteLine("\n\tLayer Details:");
                Console.WriteLine(new string('=',64));
                Console.WriteLine("{0,-10}{1,-16}{2,-16}{3,-12}{4,-12}{5,-6}",
                    "Index", "Name", "Type", "In Shape", "Out Shape", "Params");
                for (int i = 0; i < modelDepth; i++)
                {
                    BaseLayer layer = modelLayers[i];
                    Console.WriteLine(new string('-', 64));
                    Console.WriteLine("{0,-10}{1,-16}{2,-16}{3,-12}{4,-12}{5,-6}",
                    layer.layerNumber, layer.layerName, layer.layerType, "In Shape", "Out Shape", "Params");
                }
                Console.WriteLine(new string('=', 64));
            }
        }

        public class FeedForward : BaseModel
        {
            // Standard Sequential or Feed-Forward Model

            public FeedForward (string name) : base(name)
            {
                // Constructor Method for Feed-Forward-Model
                this.modelType = "Feed-Forward";

            }
        }


    }
}
