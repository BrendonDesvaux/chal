using System;
using System.Collections.Generic;
using System.Linq;

namespace TheRayTracerChallenge
{
    public class World
    {
        public List<IShape> Shapes { get; } = new List<IShape>();
        public List<PointLight> Lights { get; } = new List<PointLight>();

        public Intersections Intersect(Ray ray)
        {
            // TODO
            return new Intersections();
        }

        public Color ShadeHit(IntersectionData intersectionData, int remaining = 5)
        {
            var color = Color.Black;
            // TODO
            return color;
        }

        public Color ColorAt(Ray ray, int remaining = 5)
        {
            // TODO           
            return Color.Black;
        }

        public bool IsShadowed(Tuple point, PointLight light)
        {
            // TODO
            return false;
        }

        public bool IsShadowed(Tuple point)
        {
            // TODO
            return false;
        }

        public Color ReflectedColor(IntersectionData intersectionData, int remaining = 5)
        {
            // TODO           
            return Color.Black;
        }

        public Color RefractedColor(IntersectionData intersectionData, int remaining = 5)
        {
            // TODO           
            return Color.Black;
        }
    }
}