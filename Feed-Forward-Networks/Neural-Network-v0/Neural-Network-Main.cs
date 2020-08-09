/*
 * Landon Buell
 * Nueral Netork Test v0
 * Main Function
 * 29 July 2020
 */

using System;
using System.Numerics;

namespace Neural_Network_v0
{
    class Program
    {
        static void Main()
        {

            SequentialModel JARVIS = new SequentialModel("JARVIS");

            JARVIS.AddLayer(new InputLayer("InputLayer",new int[10,1]));
            JARVIS.AddLayer(new LinearDenseLayer("D1"));

            JARVIS.ModelSummary();

        }
    }
}
