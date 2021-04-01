using System;
using TheRayTracerChallenge.Patterns;

namespace TheRayTracerChallenge
{
    public class Material 
    {
        public IPattern Pattern { get; set; }
        public double Ambient { get;  set;}
        public double Diffuse { get;  set;}
        public double Specular { get;  set;}
        public int Shininess { get; set; }
        public double Reflective { get;  set;}
        public double Transparency { get;  set;}
        public double RefractiveIndex { get;  set;}

        public Material(IPattern pattern, double ambient = 0.1, double diffuse = 0.9, double specular = 0.9, int shininess = 200, double reflective = 0, double transparency = 0, double refractiveIndex = 1)
        {
            Pattern = pattern;
            Ambient = ambient;
            Diffuse = diffuse;
            Specular = specular;
            Shininess = shininess;
            Reflective = reflective;
            Transparency = transparency;
            RefractiveIndex = refractiveIndex;
        }
        
        public Material( Color color, double ambient=0.1, double diffuse=0.9, double specular=0.9, int shininess=200, double reflective = 0.0, double transparency = 0, double refractiveIndex = 1) : this(new SolidPattern(color), ambient, diffuse, specular, shininess, reflective, transparency, refractiveIndex)
        {
        }

        public Material() : this(new Color(1,1,1))
        {
                
        }

        public Color Lighting(PointLight light, IShape shape, Tuple point, Tuple eye, Tuple normal, bool isShadowed)
        {
            var color = Pattern.GetColorAtShape(shape, point);
            return Lighting(light, point, eye, normal, isShadowed, color);
        }

        public Color Lighting(PointLight light, Tuple point, Tuple eye, Tuple normal, bool isShadowed)
        {
            var color = Pattern.GetColor(point);
            return Lighting(light, point, eye, normal, isShadowed, color);
        }
        
        public Color Lighting(PointLight light, Tuple point, Tuple eye, Tuple normal, bool isShadowed, Color color)
        {
            return Color.Black; // TODO
        }

#region EqualsHashCode
        protected bool Equals(Material other)
        {
            return Equals(Pattern, other.Pattern) && Ambient.Equals(other.Ambient) && Diffuse.Equals(other.Diffuse) && Specular.Equals(other.Specular) && Shininess == other.Shininess  && Reflective.Equals(other.Reflective);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Material) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Pattern != null ? Pattern.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Ambient.GetHashCode();
                hashCode = (hashCode * 397) ^ Diffuse.GetHashCode();
                hashCode = (hashCode * 397) ^ Specular.GetHashCode();
                hashCode = (hashCode * 397) ^ Reflective.GetHashCode();
                hashCode = (hashCode * 397) ^ Shininess;
                return hashCode;
            }
        }
    }
#endregion

    

}