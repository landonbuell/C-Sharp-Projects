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

using MultibodySimulation.MathUtilites;

namespace MultibodySimulation
{
    namespace SystemObjects
    {
        public class BaseObject
        {
            public string name;
            public string objectType;
            public double mass;
            public double radius;

            public double volume;
            public double density;

            public BaseObject(string _name, double _mass, double _radius,
                                double[] _pos, double[] _vel)
            {
                // Constructor for SystemObject parent Class
                this.name = _name;
                this.objectType = "Base System Object";
                this.mass = _mass;
                this.radius = _radius;

                Position = _pos;
                Velocity = _vel;
                Accleration = new double[3] { 0.0, 0.0, 0.0 };

                this.volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
                this.density = mass / volume;
            }

            public double[] Position { get; set; }

            public double[] Velocity { get; set; }

            public double[] Accleration { get; set; }

            public double[] ComputeAcceleration(BaseObject _other)
            {              
                // Compute Acceleration on 'self' Due to 'other'
                double k = PhysicsUtils.G * _other.mass;
                double[] _ = MathUtils.VectorToPower(Position, 3);
                double[] vector = MathUtils.VectorDivide(Position, _ );
                double[] aclUpdate = MathUtils.ScaleVector(-k, vector);
                return aclUpdate;
            }

            public void UpdateAcceleration
            {
                // 
            }

            public void UpdateVelocity()
            {
                // Using Change to Velcity Update 
            }
        }

        public class Star : BaseObject
        {
            public float luminosity;

            public Star(string _name, double _mass, double _radius,
                        double[] _pos, double[] _vel, float _lum) : base(_name, _mass, _radius, _pos, _vel)
            {
                // Constructor for 'Star' Child Class
                this.objectType = "Star";
                this.luminosity = _lum;
            }
        }

        public class Planet : BaseObject
        {
            public Planet(string _name, double _mass, double _radius,
                        double[] _pos, double[] _vel) : base(_name, _mass, _radius, _pos, _vel)
            {
                // Constructor for 'Star' Child Class
                this.objectType = "Planet";
            }
        }

        public class Asteroid : BaseObject
        {
            public Asteroid(string _name, double _mass, double _radius,
                        double[] _pos, double[] _vel) : base(_name, _mass, _radius, _pos, _vel)
            {
                // Constructor for 'Star' Child Class
                this.objectType = "Asteroid";
            }
        }
    }
}
