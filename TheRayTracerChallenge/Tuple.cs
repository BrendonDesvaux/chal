using System;

namespace TheRayTracerChallenge
{
    public class Tuple
    {
        private readonly double[] values = new double[4];
        public double X  => values[0];
        public double Y  => values[1];
        public double Z  => values[2];
        public double W  => values[3];

        public Tuple(double x, double y, double z, double w)
        {
           // TODO
        }

        public override string ToString() => $"X: {X} Y: {Y} Z: {Z} W: {W}";
        
        public override bool Equals(object o)
        {
            // TODO
            return false;
        }

        public Tuple Add(Tuple tuple) => new Tuple(0,0,0,0); // TODO
        public static Tuple operator +(Tuple t1, Tuple t2) => t1.Add(t2);

        public Tuple Sub(Tuple tuple) => new Tuple(0, 0, 0, 0); // TODO
        public static Tuple operator -(Tuple t1, Tuple t2) => t1.Sub(t2);

        public Tuple Neg() => new Tuple(0, 0, 0, 0); // TODO
        public static Tuple operator -(Tuple t1) => t1.Neg();

        public static Tuple operator *(Tuple t1, double coeff) => new Tuple(0, 0, 0, 0); // TODO
        public static Tuple operator *(double coeff, Tuple t1) => t1 * coeff;
        public static Tuple operator /(Tuple t1, double coeff) => new Tuple(0, 0, 0, 0); // TODO

        public double Magnitude => 0; // TODO

        public Tuple Normalize()
        {
            return new Tuple(0, 0, 0, 0); // TODO
        }

        public double DotProduct(Tuple v) => 0; // TODO

        public static Tuple operator *(Tuple t1, Tuple t2) => t1.CrossProduct(t2);
        public Tuple CrossProduct(Tuple v) => Helper.CreateVector(0,0,0); // TODO

        public double this[in int i] => values[i];
        public Tuple Reflect(Tuple normal) => new Tuple(0, 0, 0, 0); // TODO
    }
}