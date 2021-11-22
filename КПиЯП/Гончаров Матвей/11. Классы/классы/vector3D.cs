using System;
using System.Collections.Generic;
using System.Text;

namespace классы
{
    public class Vector3D
    {
        private double x, y, z;
        public Vector3D() { }
        public Vector3D(double x, double y, double z)
        {
            this.x = x; this.y = y; this.z = z;
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static double Scal(Vector3D v1, Vector3D v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }
        public void Scal(double sc)
        {
            this.x *= sc;
            this.y *= sc;
            this.z *= sc;
        }
        public static bool operator !=(Vector3D v1, Vector3D v2)
        {
            return v1.x != v2.x && v1.y != v2.y && v1.z != v2.z;
        }
        public static bool operator ==(Vector3D v1, Vector3D v2)
        {
            return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z; ;
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }
        public static bool operator >(Vector3D v1, Vector3D v2)
        {
            return v1.Length() > v2.Length();
        }
        public static bool operator <(Vector3D v1, Vector3D v2)
        {
            return v1.Length() < v2.Length();
        }
        public static bool LengthEqual(Vector3D v1, Vector3D v2)
        {
            return v1.Length() == v2.Length();
        }
        public static bool LengthNotEqual(Vector3D v1, Vector3D v2)
        {
            return v1.Length() != v2.Length();
        }
    }
}
