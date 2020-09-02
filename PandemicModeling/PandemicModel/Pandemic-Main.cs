/*
 * Landon Buell
 * Pandemic Modeling
 * Main Executable
 * 1 September 2020
 */

using System;
using System.Collections.Generic;

namespace PandemicModel
{
    class Program
    {
        static void Main()
        {

            // Create the World, Add People and Locations
            WorldBoard WorldSystem = new WorldBoard("Earth");
            WorldSystem.AddnVectors(100);

            

        }
    }
}
