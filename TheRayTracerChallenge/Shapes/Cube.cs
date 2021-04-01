using System;

namespace TheRayTracerChallenge.Shapes
{
    public class Cube : AbstractShape
    {
        public override Bounds Box => new Bounds {PMin =  Helper.CreatePoint(-1, -1, -1), PMax = Helper.CreatePoint(1, 1, 1)};

        public override Intersections IntersectLocal(Ray ray)
        {
            return new Intersections();//TODO
        }

        public override Tuple NormalAtLocal(Tuple worldPoint, Intersection hit=null)
        {
            return new Tuple(0, 0, 0, 0);//TODO
        }
    }
}