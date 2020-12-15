using System;
using System.Collections.Generic;
using System.Text;

namespace MultibodySimulation
{
    public class Body
    {

        public string BodyName { get; protected set; }
        public string BodyType { get; protected set; }
        public double[] Pos { get; protected set; }
        public double[] Vel { get; protected set; }

        protected double _mass;
        protected double _radius;
        protected double _volume;
        protected double _density;

        public Body (string name, double mass , double radius)
        {
            // Constructor w/o Coordinates
            BodyName = name;
            _mass = mass;
            _radius = radius;

            Pos = new double[3] { 0.0, 0.0, 0.0 };
            Vel = new double[3] { 0.0, 0.0, 0.0 };
        }

        public Body(string name, double mass, double radius,
                    double[] position, double[] velocity)
        {
            // Constructor  w/ Coordinates
            BodyName = name;
            _mass = mass;
            _radius = radius;

            Pos = position;
            Vel = velocity;
        }

        public double Mass { get { return _mass; } }

        public double[] StateVector
        {
            get
            {
                double[] state = new double[6];
                Pos.CopyTo(state, 0);
                Vel.CopyTo(state, 3);
                return state;
            }
            set
            {
                for (int i = 0; i < 3; i++) { Pos[i] = value[i]; }
                for (int i = 3; i < 6; i++) { Vel[i] = value[i]; }
            }
        }



    }
}
