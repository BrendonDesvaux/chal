using NFluent;
using TheRayTracerChallenge.Patterns;
using Xunit;

namespace TheRayTracerChallenge.tests.Patterns
{
    public class RingPatternTests
    {
        [Fact]
        public void BasicTest()
        {
            var pattern = new RingPattern(Color.White, Color.Black);
            Check.That(pattern.GetColor(Helper.CreatePoint(0, 0, 0))).IsEqualTo(Color.White);
            Check.That(pattern.GetColor(Helper.CreatePoint(1, 0, 0))).IsEqualTo(Color.Black);
            Check.That(pattern.GetColor(Helper.CreatePoint(0, 0, 1))).IsEqualTo(Color.Black);
            Check.That(pattern.GetColor(Helper.CreatePoint(0.708, 0, 0.708))).IsEqualTo(Color.Black);
        }
    }
}