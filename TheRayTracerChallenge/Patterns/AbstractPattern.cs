namespace TheRayTracerChallenge.Patterns
{
    public abstract class AbstractPattern : IPattern
    {
        public Matrix Transform { get; set; } = Helper.CreateIdentity();

        public abstract Color GetColor(Tuple point);
        
        public Color GetColorAtShape(IShape shape, Tuple point)
        {
           // TODO
            return Color.Black;
        }

        protected AbstractPattern()
        {
        }

        protected AbstractPattern(Matrix transform)
        {
            Transform = transform;
        }
    }
}