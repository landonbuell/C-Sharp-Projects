/*
 * Landon Buell
 * Nueral Netork Test v0
 * Model Objects
 * 29 July 2020
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using NeuralNetworkv0.Layers;
using NeuralNetworkv0.ActivationFunctions;
using NeuralNetworkv0.Optimizers;
using NeuralNetworkv0.Initializers;

namespace NeuralNetworkv0
{
    namespace Models
    {

        public class SequentialNetwork
        {
            private List<Layers.BaseLayer> networkLayers = new List<Layers.BaseLayer>();
            private int networkDepth = 0;
            public int totalWeights;
            public int totalBiases;
            public int totalParams;

            public SequentialNetwork(string name)
            {
                // Constructor Method for Sequential Model object
                NetworkName = name;
                BatchSize = 1;
                SolverMethod = null;
            }

            public SequentialNetwork(string name, int batch)
            {
                // Constructor Method for Sequential Model object
                NetworkName = name;
                BatchSize = batch;
                SolverMethod = null;
            }

            public string NetworkName { get; set; }

            public int BatchSize { get; set; }

            public BaseOptimizer SolverMethod { get; set; }

            public void AddLayer(BaseLayer layer)
            {
                // Add Layer to Bottom of Network Layer Stacks
                try
                {
                    if (networkDepth == 0)
                    {
                        // 0-th Layer Must be Input Layer, set Batch Size
                        Debug.Assert(layer.LayerType == "Input Layer");
                        BatchSize = layer.InputShape[1];
                    }
                    else
                    {
                        int[] previousOutputShape = networkLayers[networkDepth - 1].OutputShape;
                        layer.InputShape = previousOutputShape;                       
                        layer.LayerNumber = networkDepth;
                        // Reset Layer Output Shape ... Check this....
                        layer.OutputShape = new int[2] { layer.OutputShape[0], layer.InputShape[1]};

                    }
                    // Add the Layer to the network
                    networkLayers.Add(layer);
                    networkDepth += 1;
                }
                catch
                {
                    Console.WriteLine("\n\tERROR! - Cannot Add Layer {0} to model", layer.LayerName);
                }
            }
         
            public int ComputeTotalParams()
            {
                // Compute the Total number of Parameters in Network model
                this.totalWeights = 0;
                this.totalBiases = 0;
                this.totalParams = totalWeights + totalBiases;
                foreach (var layer in networkLayers)
                {
                    totalWeights =+ (layer._weightShape[0] * layer._weightShape[1]);
                    totalBiases = +(layer._biasShape[0]);
                }
                // Set & Return total number of params
                this.totalParams = totalWeights + totalBiases;
                return totalParams;
            }

            public void AssembleModel(BaseOptimizer solver)
            {
                // Assembled Model, Intialize Layers
                ComputeTotalParams();
                SolverMethod = solver;

            }

            public double[,] ForwardPass(double[,] X)
            {
                // Execute Forward Pass of Model layers w/ Input X
                Debug.Assert(X.GetLength(1) == BatchSize);
                foreach (var layer in networkLayers)
                {
                    // Call Each layer
                    X = layer.CallLayer(X);
                }
                // Return Final Ouput
                return X;
            }



            public void ModelSummary()
            {
                // Print Model Summary to Console - Header
                Console.WriteLine("Model Name:\t{0}", NetworkName);
                Console.WriteLine("Model Depth:\t{0}", networkDepth);
                string stringFormat = "{0,-16}{1,-16}{2,-32}{3,-16}{4,-16}\n";
                Console.Write(string.Format(stringFormat,
                    "Layer Number", "Layer Name", "Layer Type", "Input Shape", "Output Shape"));
                Console.WriteLine(string.Concat(Enumerable.Repeat("-", 128)));
                // Print Model Summary to Console - Layer Details
                foreach (Layers.BaseLayer layer in networkLayers)
                {
                    Console.Write(stringFormat,
                        layer.LayerNumber, layer.LayerName, layer.LayerType,
                        string.Concat(layer.InputShape[0], " , ", layer.InputShape[1]),
                        string.Concat(layer.OutputShape[0], " , ", layer.OutputShape[1]));
                }
                Console.WriteLine(string.Concat(Enumerable.Repeat("-", 128)));
                // Print Model Summary to Console - Footer
                Console.WriteLine("Total Model Parameters:\t{0}", totalParams);
                Console.WriteLine("Model Optimizer Method:\t{0}", SolverMethod);
            }

        }
    }
}
