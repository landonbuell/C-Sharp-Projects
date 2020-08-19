using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MultibodySimulation.SystemObjects;

namespace MultibodySimulation
{
    namespace MathUtilites
    {
        public class PhysicsUtils
        {
            public static double G { get; set; }

        }

        public class MathUtils
        {
            public static double[] ScaleVector (double c, double[] A)
            {
                // Scale each index of Vector V by A
                double[] B = new double[A.Length];
                for (int i = 0; i < A.Length; i++)
                    B[i] = c * A[i];
                return B;
            }

            public static double[] VectorAdd(double[] A, double[] B)
            {
                // Compute Inner Product beteen arrays A and B
                Debug.Assert(A.Length == B.Length);
                double[] C = new double[A.Length];
                for (int i = 0; i < C.Length; i++)
                    C[i] = A[i] + B[i];
                return C;
            }

            public static double[] VectorDivide (double[] A, double[] B)
            {
                // Compute Inner Product beteen arrays A and B
                Debug.Assert(A.Length == B.Length);
                double[] C = new double[A.Length];
                for (int i = 0; i < C.Length; i++)
                    try { C[i] = A[i] / B[i]; }
                    catch { C[i] = 0.0; }               
                return C;
            }

            public static double[] VectorToPower (double[] A, int p)
            {
                // Raise each Element in 'A' to the power of 'p'
                double[] B = new double[A.Length];
                for (int i = 0; i < A.Length; i++)
                    B[i] = Math.Pow(A[i], p);
                return B;
            }

            public static double[] DotProduct(double[] A, double[] B)
            {
                // Compute Inner Product beteen arrays A and B
                Debug.Assert(A.Length == B.Length);
                double[] C = new double[A.Length];
                for (int i = 0; i < C.Length; i++)
                    C[i] = A[i] * B[i];
                return C;
            }

            

        }
    }

    
}
