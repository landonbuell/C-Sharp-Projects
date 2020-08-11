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

namespace Neural_Network_v0
{
    public class SequentialNetwork
    {
        private List<Layer> networkLayers = new List<Layer>(); 
        private int networkDepth = 0;

        public SequentialNetwork(string name)
        {
            // Constructor Method for Sequential Model object
            NetworkName = name;
            BatchSize = 1;
        }

        public SequentialNetwork(string name, int batch)
        {
            // Constructor Method for Sequential Model object
            NetworkName = name;
            BatchSize = batch;
        }

        public string NetworkName 
        {
            // Get or Set the name of this Network Model
            get; set; 
        }

        public int BatchSize
        {
            // Get or Set the Batch Size
            get; set;
        }

        public Optimizer SolverMethod
        {
            // Get or Set Optimizer Algorithm to Network
            get; set;
        }

        public void AddLayer(Layer layer)
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
                    layer.OutputShape = new int[2] { layer.Neurons, BatchSize };
                    layer.LayerNumber = networkDepth;

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
            return 0;
        }

        public void AssembleModel(Optimizer solver)
        {
            // Assembled Model, Intialize Layers
            SolverMethod = solver;

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
            foreach (Layer layer in networkLayers) 
            {
                Console.Write(stringFormat,
                    layer.LayerNumber, layer.LayerName, layer.LayerType, 
                    string.Concat(layer.InputShape[0]," , ", layer.InputShape[1]),
                    string.Concat(layer.OutputShape[0], " , ", layer.OutputShape[1]));
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 128)));
            // Print Model Summary to Console - Footer
            Console.WriteLine("Model Optimizer Method:\t{0}", SolverMethod);
        }

    }
}
