/*
 * Landon Buell
 * Multibody Simulation
 * SystemObjects
 * 18 August 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MultibodySimulation.SystemObjects;

namespace MultibodySimulation
{
    namespace SystemTypes
    {
        class BaseSystem
        {
            public string name;
            public string systemType;
            public List<BaseObject> systemObjects;
            public int nObjects;

            public BaseSystem(string _name)
            {
                // Constructor foe "Base System" Class
                this.name = _name;
                this.systemType = "Base System";
                this.systemObjects = new List<BaseObject>();
                this.nObjects = 0;
            }

            public void AddObject (BaseObject _object)
            {
                // Add Object to this System
                systemObjects.Add(_object);
                nObjects = systemObjects.Count();
            }

            public void RemoveObject(int index)
            {
                // Remove Object from this System by Index
                systemObjects.RemoveAt(index);
                nObjects = systemObjects.Count();
            }

            public void ComputeSystemDetails()
            {
                // Compute Details of System

            }

            public double TotalMass { get; set; }

            public double AverageDensity { get; set; }

            public double[] CenterOfMass { get; set; }

            public double[] NetVelocity { get; set; }

            public void CallSystem()
            {
                // Move System Forward in time:
            }
        }
    }
}
