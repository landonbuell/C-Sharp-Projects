/*
 * Landon Buell
 * Multibody Simulation
 * Utilities
 * 16 July 2020
 */

using System;
using System.Collections.Generic;

namespace Multibody_Simulation_v0
{
    public class Body
    {
        // Create Name & Mass of body
        public string name;
        public double mass;
        public double volume;
        public double density;
        public double radius;
        // Create position, velocity, accl vectors
        public double[] pos;
        public double[] vel;
        public double[] acl;

        public Body(string name, double mass, double radius,
                        double[] r, double[] dr)
        {
            // Instatiate Body Class Object
            this.name = name;
            this.mass = mass;
            this.radius = radius;
            this.volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            this.density = mass / volume;
            // Set Position, Velocity, and Acceleration Vectors
            this.pos = r;
            this.vel = dr;
            this.acl = new double[3] { 0,0,0 };
        }

        public (string, List<double>) __getparams__()
        {
            // Get All Parameters for this body object
            List<double> data = new List<double>();
            data.Add(mass);
            data.Add(radius);
            data.AddRange(pos);
            data.AddRange(vel);
            return (name, data);

        }
    }
}
