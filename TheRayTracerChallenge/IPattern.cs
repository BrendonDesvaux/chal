namespace TheRayTracerChallenge
{
    public interface IPattern : ITransformable
    {
        Color GetColor(Tuple point);
        Color GetColorAtShape(IShape shape, Tuple point);
    }
}