/*
 * Landon Buell
 * Nueral Netork Test v0
 * Model Objects
 * 29 July 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural_Network_v0
{
    public class SequentialNetwork
    {
        // Init Variables for Seqential Model Parent Class
        public string networkName;
        public List<Layer> networkLayers;
        public int networkDepth;

        public SequentialNetwork(string name)
        {
            // Constructor Method for Sequential Model object
            this.networkName = name;
            this.networkLayers = new List<Layer>();
            this.networkDepth = 0;
        }

        public void AddLayer(Layer layer)
        {
            // Add Layer to Bottom of Network Layer Stacks
            try
            {
                networkLayers.Add(layer);
                layer.SetLayerNum(networkDepth);
                networkDepth += 1;
            }
            catch
            {
                Console.WriteLine("\n\tERROR! - Cannot Add Layer {0} to model", layer.layerName);
            }
        }

        public void AddOptimizer()
        {
            // Add Optimizer Algorithm to Network
        }
        

        public void ModelSummary()
        {
            // Print Model Summary to Console
            Console.WriteLine("Model Name:\t{0}", networkName);
            Console.WriteLine("Model Depth:\t{0}", networkDepth);
            string stringFormat = "{0,-16}{1,-16}{2,-32}{3,-16}{4,-16}\n";
            Console.Write(string.Format(stringFormat,
                "Layer Number", "Layer Name", "Layer Type", "Input Shape", "Output Shape"));
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 128)));
            foreach (Layer layer in networkLayers) 
            {
                Console.Write(string.Format(stringFormat,
                layer.layerNumber, layer.layerName, layer.layerType, 
                string.Concat(layer.inputShape[0]," , ",layer.inputShape[1]),
                string.Concat(layer.outputShape[0]," , ",layer.outputShape[1])));
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 128)));
        }

    }
}
