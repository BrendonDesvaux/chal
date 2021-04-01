using System.Collections.Generic;
using System.Linq;

namespace TheRayTracerChallenge
{
    public class Intersections : List<Intersection>
    {
        public Intersections(params Intersection[] intersections) : base(intersections)
        {
            Sort();
        }
        
        public Intersections(IEnumerable<Intersection> intersections) : base(intersections)
        {
            Sort();
        }

        public Intersections()
        {
            
        }

        public Intersection Hit() => this.FirstOrDefault(i => i.T >= 0);
    }
}