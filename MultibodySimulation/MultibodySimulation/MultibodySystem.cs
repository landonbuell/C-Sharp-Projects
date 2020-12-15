using System;
using System.Collections.Generic;
using System.Text;

namespace MultibodySimulation
{
    public class MultibodySystem
    {

        public string Name { get; protected set; }

        public List<Body> BodyList { get; protected set; }

        public double[] CurrentState { get; protected set; }

        protected int _nBodies;
        protected double _totalMass;
        protected double[] _centerOfMass;

        public MultibodySystem(string name)
        {
            // MultibodySystem Constructor w/ Name
            Name = name;
            BodyList = new List<Body>();
        }

        public MultibodySystem(string name, List<Body> bodyList )
        {
            // MultibodySystem Constructor w/ Name + List
            Name = name;
            BodyList = bodyList
        }

        public void AddBody (Body newBody)
        {
            // Add Body to BodyList
            BodyList.Add(newBody);
            _nBodies += 1;
        }

        public void PopBody(Body tgtBody)
        {
            // Add Body to BodyList
            BodyList.Remove(tgtBody);
            _nBodies -= 1;
        }

        public double[] GetMasses()
        {
            // Get Array of Masses from System
            double[] masses = new double[_nBodies];
            for (int i = 0; i < _nBodies; i++)
            {
                masses[i] = BodyList[i].Mass; 
            }
            return masses;
        }

        public double GetTotalMass()
        {
            // Get Total Mass of all bodies in System
            _totalMass = 0.0;
            for (int i = 0; i < _nBodies; i++)
                _totalMass += BodyList[i].Mass;
            return _totalMass;
        }

        public double[] GetCenterOfMass()
        {
            _centerOfMass = new double[3] { 0.0, 0.0, 0.0 };
            _totalMass = GetTotalMass();
            for (int i = 0; i < _nBodies; i++)
            {
                for (int j = 0; j < 3; j++) 
                { 
                    _centerOfMass[j] += BodyList[i].Pos[j] * BodyList[i].Mass; 
                }
            }         
            for (int k = 0; k < 3; k++) { _centerOfMass[k] /= _totalMass };
            return _centerOfMass;
        }

        public void CallSystem(double time, double[] state)
        {
            // Call System at Current Time & Current State
        }





    }
}
