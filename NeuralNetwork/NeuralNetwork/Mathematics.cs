/*
 * Landon Buell
 * Neural Network
 * Layer Objects
 * 8 September 2020
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NeuralNetwork
{
    namespace MathematicalUtilities
    {
        public class CustomArray
        {
            public static double[] GetRow(double[,] A, int row)
            {
                // Get Row "row" of Matrix A
                double[] B = new double[A.GetLength(1)];
                for (int i = 0; i < A.GetLength(1); i++)
                    B[i] = A[row, i];
                return B;
            }

            public static double[] GetCol (double[,] A, int col)
            {
                // Get Row "col" of Matrix A
                double[] B = new double[A.GetLength(0)];
                for (int i = 0; i < A.GetLength(0); i++)
                    B[i] = A[i, col];
                return B;
            }

            public static double[,] Transpose(double[,] A)
            {
                // Tranpose Matrix into matrix B
                int nrows = A.GetLength(0);
                int ncols = A.GetLength(1);
                double[,] B = new double[ncols, nrows];
                for (int i = 0; i < nrows; i++)      
                    for (int j = 0; j < ncols; j++)
                        B[i, j] = A[j, i];
                return B;
            }
        }
    

        class LinearAlgebra
        {
            public static double[,] IndentityMatrix (int N)
            {
                // Create N x N Identity matrix
                double[,] ID = new double[N,N];
                for (int i = 0; i < N; i++)
                {
                    for(int j = 0; j < N; j++)
                    {
                        if (i == j)
                            ID[i, j] = 1.0;
                        else
                            ID[i, j] = 0.0;
                    }
                }
                return ID;   
            }

            public static double DotProduct(double[] A, double[] B)
            {
                // Compute Dot Produce Between 
                Debug.Assert(A.Length == B.Length);
                double _c = 0.0;
                for (int i = 0; i < A.Length; i++)
                    _c += (A[i] * B[i]);
                return _c;
            }

            public static double[,] HadamardProduct (double[,] A, double[,] B)
            {
                // Compute the Hadamard-Product of Matrix A and B
                Debug.Assert(A.GetLength(0) == B.GetLength(0));
                Debug.Assert(A.GetLength(1) == B.GetLength(1));
                double[,] C = new double[A.GetLength(0), A.GetLength(1)];
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.GetLength(1); j++)
                        C[i, j] = (A[i, j] * B[i, j]);
                return C;
            }

            public static double[,] MatrixProduct (double[,] A, double[,] B)
            {
                // Compute Standard Matrix Produce of Matrix A and B
                Debug.Assert(A.GetLength(1) == B.GetLength(0));
                double[,] C = new double[A.GetLength(0), B.GetLength(1)];
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        double[] _a = CustomArray.GetRow(A, i);
                        double[] _b = CustomArray.GetCol(B, j);
                        C[i, j] = DotProduct(_a, _b);
                    }
                }
                return C;
            }
        }

        class BaseActivationFunction
        {
            // Parent Activation Function Class
        }

    }
    
}
