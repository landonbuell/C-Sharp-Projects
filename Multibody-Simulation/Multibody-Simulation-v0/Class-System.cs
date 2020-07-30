/*
 * Landon Buell
 * Multibody Simulation
 * Utilities
 * 16 July 2020
 */

using System.Collections.Generic;
using System.Linq;

namespace Multibody_Simulation_v0
{
    public class Multibody_System
    {
        // System Class Holds a list of all Body objects in the current system
        public string name;
        public List<Body> bodies;

        public Multibody_System(string name, List<Body> bodies = null)
        {
            // Constructor for MultiBody System Class Object
            this.name = name;
            this.bodies = bodies;
        }

        public void AddBody(Body body_inst)
        {
            // Add an Instance of a Body Object to this System
            this.bodies.Add(body_inst);
        }

        public void RemoveBody()
        {
            // Remove an Instance of a Body Object from this System
        }

        public List<Body> __getBodies__()
        {
            // return a list of all bodies in Current System
            return bodies;
        }

        public void call_system()
        {
            // Run main Simulation
        }

        public List<float> SystemDetails()
        {
            // Export System Detials as List of Floats
            List<float> details = new List<float>();

            // Compute Total Mass
            // Compute Center of Masses [x,y,z]
            // Compite Net Velocities [dx,dy,dz]
            //


            return details;
        }

    }
}
