using System;

namespace TheRayTracerChallenge.Shapes
{
    public class Cone : AbstractShape
    {
        public double Minimum { get; set; }
        public double Maximum { get; set; }
        public bool Closed { get; set; }
        public override Bounds Box => new Bounds { PMin = Helper.CreatePoint(-1, Minimum, -1), PMax = Helper.CreatePoint(1, Maximum, 1) };

        public Cone(double minimum = double.NegativeInfinity, double maximum = double.PositiveInfinity, bool closed = false)
        {
            Minimum = minimum;
            Maximum = maximum;
            Closed = closed;
        }

        public override Intersections IntersectLocal(Ray ray)
        {
            var xs = new Intersections();
            // TODO
            return xs;
        }

        public override Tuple NormalAtLocal(Tuple worldPoint, Intersection hit = null)
        {
            return new Tuple(0, 0, 0, 0);
        }

        // a helper function to reduce duplication.
        // checks to see if the intersection at `t` is within a radius
        // of y (the radius of your cone) from the y axis.
        private bool CheckCap(Ray ray, double t, double y)
        {
            var x = ray.Origin.X + t * ray.Direction.X;
            var z = ray.Origin.Z + t * ray.Direction.Z;
            return (x * x + z * z) <= y * y;
        }

        private void IntersectCaps(Ray ray, Intersections xs)
        {
            // caps only matter if the cone is closed, and might possibly be intersected by the ray.
            if (!Closed || Math.Abs(ray.Direction.Y) <= double.Epsilon)
            {
                return;
            }

            // check for an intersection with the lower end cap by intersecting
            // the ray with the plane at y=cone.minimum
            var t = (Minimum - ray.Origin.Y) / ray.Direction.Y;
            if (CheckCap(ray, t, Minimum))
            {
                xs.Add(new Intersection(t, this));
            }

            // check for an intersection with the upper end cap by intersecting
            // the ray with the plane at y=cone.maximum
            t = (Maximum - ray.Origin.Y) / ray.Direction.Y;
            if (CheckCap(ray, t, Maximum))
            {
                xs.Add(new Intersection(t, this));
            }
        }
    }
}