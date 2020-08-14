/*
 * Landon Buell
 * Nueral Netork Test v0
 * Mathematical Utilities
 * 29 July 2020
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NeuralNetworkv0
{
   
    public class LinearAlgebra
    {
        // Class to do basic Linear Algebra operations 

        public static double[,] Transpose (double[,] A)
        {
            // Transpose 2D input array
            double[,] B = new double[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[j, i] = A[i, j];
                }
            }
            return B;
        }

        public static double[,] Reshape(double[,] A, int[] newShape)
        {
            // Reshape 2D array in new Shaped 2D array
            int rows = newShape[0], cols = newShape[1];
            Debug.Assert(A.Length == ( rows * cols ));
            double[,] B = new double[rows, cols];
            double[] _A = To1DArray(A);
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0 ; j < cols ; j++)
                {
                    B[i, j] = _A[k];
                    k += 1;
                }
            }
            return B;
        }

        public static double[] GetRow (int i ,double[,] A)
        {
            // Get row 'i' of 2D array A
            double[] B = new double[A.GetLength(1)];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                B[j] = A[i, j];
            }
            return B;
        }

        public static double[] GetCol(int i, double[,] A)
        {
            // Get column 'i' of 2D array A
            double[] B = new double[A.GetLength(0)];
            for (int j = 0; j < A.GetLength(0); j++)
            {
                B[j] = A[j, i];
            }
            return B;
        }

        public static double[] To1DArray (double[,] A)
        {
            // Convert 2D Array A to flattened 1D Array
            List<double> _C = new List<double>();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    _C.Add(A[i, j]);
                }
            }
            return _C.ToArray();
        }

        public static double DotProduct (double[] A, double[] B)
        {
            // Compute the Dot-Product between array A and array B
            Debug.Assert(A.Length == B.Length);
            double _sum = Convert.ToDouble(0);
            for (int i = 0; i < A.Length; i++)
            {
                _sum += A[i] * B[i];
            }
            return _sum;
        }

        public static double[,] MatrixMultiply (double[,]A, double[,] B)
        {
            // Compute Matrix Product of Array A and Array B
            Debug.Assert(A.GetLength(1) == B.GetLength(0));
            double[,] C = new double[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double[] _a = GetRow(i, A);
                    double[] _b = GetCol(j, B);
                    C[i, j] = DotProduct(_a, _b);
                }
            }
            return C;
        }

        public static double[,] HadamardProduct (double[,] A, double[,] B)
        {
            // Compute Element-Wise Product of Array A and Array B
            Debug.Assert(A.GetLength(0) == B.GetLength(0));
            Debug.Assert(A.GetLength(1) == B.GetLength(1));
            double[,] C = new double[A.GetLength(0), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i,j] * B[i,j];
                }
            }
            return C;
        }

        public static double[,] MatrixAdd(double[,] A, double[,] B)
        {
            // Compute Element-Wise Addition of Array A and Array B
            Debug.Assert(A.GetLength(0) == B.GetLength(0));
            Debug.Assert(A.GetLength(1) == B.GetLength(1));
            double[,] C = new double[A.GetLength(0), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }

        public static double[,] ExpandColumn (double[,] A, int cols)
        {
            // Expand Column vecotor into Matrix of identical Columns
            Debug.Assert(A.GetLength(1) == 1);
            double[,] B = new double[A.GetLength(0), cols];
            for (int i = 0; i < A.GetLength(1); i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    B[i, j] = A[i, 0];
                }
            }
            return B;
         }
    }
}
