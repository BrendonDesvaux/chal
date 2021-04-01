using System.Linq;

namespace TheRayTracerChallenge.Shapes
{
    public abstract class AbstractCsg : Group
    {
        public IShape Left { get; }
        public IShape Right { get; }

        public abstract bool IntersectionAllowed(bool leftHit, bool insideLeft, bool insideRight);

        protected AbstractCsg(IShape left, IShape right)
        {
            Left = left;
            Right = right;
            left.Parent = this;
            right.Parent = this;
            Shapes.Add(Left);
            Shapes.Add(Right);
        }

        public override bool Contains(IShape shape)
        {
            return ReferenceEquals(Right, shape) || ReferenceEquals(Left, shape) || Right.Contains(shape) || Left.Contains(shape);
        }

        public Intersections Filter(Intersections xs)
        {
            
            // prepare a list to receive the filtered intersections
            var result = new Intersections();
            // TODO
            return result;
        }

        public override Intersections IntersectLocal(Ray ray)
        {
            Intersections leftXs = Left.Intersect(ray);
            var rightXs = Right.Intersect(ray);
            Intersections result;
            if (leftXs.Any() || rightXs.Any())
            {
                 var xs = new Intersections(leftXs.Concat(rightXs));
                 result = Filter(xs);
            }
            else
            {
                result = new Intersections();
            }

            return result;
        }
    }
}