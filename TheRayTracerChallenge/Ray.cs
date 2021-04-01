namespace TheRayTracerChallenge
{
    public class Ray
    {
        public Tuple Origin { get; }
        public Tuple Direction { get; }

        public Ray(Tuple origin, Tuple direction)
        {
            Origin = origin;
            Direction = direction;
        }

        public Tuple Position(double t) => new Tuple(0, 0, 0, 0); // TODO

        public Ray Transform(Matrix m)
        {
            return new Ray(new Tuple(0, 0, 0, 0), new Tuple(0, 0, 0, 0) ); // TODO
        }
    }
}