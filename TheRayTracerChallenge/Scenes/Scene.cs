using System;
using System.IO;
using TheRayTracerChallenge;
using TheRayTracerChallenge.Patterns;
using TheRayTracerChallenge.Shapes;

namespace ray_tracer_demos
{
    public class Scene
    {
        private readonly World world = new World();
        public event Action<int, int> RowRendered;
        protected readonly double Pi = Math.PI;
        protected Color Red = Color._Red;
        protected Color Green = Color._Green;
        protected Color Blue = Color._Blue;
        
        public void Render(string file, double camX, double camY, double camZ, double lookX=0, double lookY =0, double lookZ =0)
        {
            var point = Helper.CreatePoint(camX, camY, camZ);
            var look = Helper.CreatePoint(lookX, lookY, lookZ);
            
            var camera = new Camera(600, 400, Math.PI / 3, Helper.ViewTransform(point, look, Helper.CreateVector(0, 1, 0)));

            var canvas = camera.Render(world);
            canvas.Save(file);
        }

        public IShape DefaultFloor()
        {
            var floor = new Plane
            {
                Material = new Material(new CheckerPattern(Color.Black, Color.White))
            };
            world.Add(floor);
            return floor;
        }
        
        protected T Add<T>(T shape) where T : IShape
        {
            world.Add(shape);
            return shape;
        }

        protected void Add(params IShape[] shapes)
        {
            world.Add(shapes);
        }

        protected void Light(double x, double y, double z)
        {
            Light(x, y, z, Color.White);
        }
        
        protected void Light(double x, double y, double z, Color c)
        {
            world.Lights.Add(new PointLight(Helper.CreatePoint(x, y, z), c));
        }
    }
}