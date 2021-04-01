using System;

namespace TheRayTracerChallenge
{
    public class Matrix
    {
        private double[][] Values { get; }
        private Matrix Inversed { get; set; }
        public static Matrix Identity = new Matrix(4);

        static Matrix()
        {
           // TODO
        }
        
        public Matrix(int size)
        {
            // TODO
        }

        public Matrix(int size, double[][] values) : this(size)
        {
           // TODO
        }

        public Matrix(int size, params double[] values) : this(size)
        {
            // TODO
        }

        public int Size => Values.Length;

        public double this[int i, int j]
        {
            get => Values[i][j];
            set => Values[i][j] = value;
        }

        public bool Equals(Matrix m)
        {
            // TODO

            return true;
        }

        public override bool Equals(object m)
        {
            if (m == null) return false;

            if (m is Matrix matrix)
            {
                return Equals(matrix);
            }

            return false;
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (ReferenceEquals(m1, null) && ReferenceEquals(m2, null))
            {
                return true;
            }
            if (! ReferenceEquals(m1, null) && ReferenceEquals(m2, null))
            {
                return false;
            }
            
            return !ReferenceEquals(m1, null) && m1.Equals(m2);
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        public static Matrix Multiply(Matrix m1, Matrix m2)
        {
            var m = new Matrix(m1.Size);
            // TODO

            return m;
        }

        public static Matrix operator *(Matrix m1, Matrix m2) => Multiply(m1, m2);

        public static Tuple Multiply(Matrix m, Tuple t)
        {
           // TODO
           return new Tuple(0,0,0,0);
        }
        
        public static Tuple operator *(Matrix m1, Tuple t) => Multiply(m1, t);
        public static Tuple operator *(Tuple t, Matrix m1) => Multiply(m1, t);

        public Matrix Transpose()
        {
            var m = new Matrix(Size);
            // TODO
            return m;
        }

        public Matrix SubMatrix(int row, int column)
        {
            var m= new Matrix(Size-1);
            // TODO
            return m;
        }

        public double Determinant()
        {
            double det = 0;
           // TODO

            return det;
        }

        public double Minor(int row, int column)
        {
            // TODO
            return 0;
        }

        public double Cofactor(int row, int column)
        {
            return 0;// TODO
        }

        public bool Invertible() => Determinant() != 0;

        public Matrix Inverse()
        {
            Inversed = new Matrix(Size);
            // TODO

            return Inversed;
        }
    }
}