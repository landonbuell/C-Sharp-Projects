/*
 * Landon Buell
 * Multibody Simulation
 * Utilities
 * 16 July 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace Multibody_Simulation_v0
{
    public class Multibody_System
    {
        // System Class Holds a list of all Body objects in the current system
        public string name;
        public List<Body> bodies;
        public double totalMass;
        public double[] centerOfMass;
        public double[] netVelocity;

        public Multibody_System(string _name, List<Body> _bodies)
        {
            // Constructor for MultiBody System Class Object with all Given params
            this.name = _name;
            this.bodies = _bodies;
            UpdateSystemDetails();
        }

        public Multibody_System (string _name)
        {
            // Constructor for is ONLY name is given
            this.name = _name;
            List<Body> _bodies = new List<Body>();
            this.bodies = _bodies;
        }

        public void UpdateName (string _name)
        {
            // Update System Name Parameter
            this.name = _name;
        }

        public void AddBody(Body body_inst)
        {
            // Add an Instance of a Body Object to this System
            bodies.Add(body_inst);
            UpdateSystemDetails();
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

        public void UpdateSystemDetails()
        {
            // Export System Detials as List of Floats
            List<float> details = new List<float>();

            // Compute Total Mass & Net Velocity & Center of mass         
            double _totalMass = 0.0;
            double[] _netVelocity = new double[] { 0,0,0};
            double[] _centerOfMass = new double[] { 0, 0, 0, };
            if (bodies.Count > 0)
            {
                // Loop through system objects
                foreach (Body body in bodies)
                {
                    _totalMass += body.mass;
                    for (int i = 0; i < 3; i++)
                        _netVelocity[i] += body.vel[i];
                }
                foreach (var body in bodies)
                {
                    for (int i = 0; i < 3; i++)
                        _centerOfMass[i] += (body.mass * body.vel[i]);
                }
                for (int i = 0; i < 3; i++)
                    _centerOfMass[i] /= _totalMass;           
            }
            // Set Attributes to System Object
            this.totalMass = _totalMass;
            this.centerOfMass = _centerOfMass;
            this.netVelocity = _netVelocity;

        }

        public List<double> __getSystemDetails__()
        {
            // Return System Details in one object for GUI
            List<double> data = new List<double>();
            data.Add(totalMass);
            data.AddRange(centerOfMass);
            data.AddRange(netVelocity);
            return data;
        }

    }
}
