using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabMatrix2x2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vec1 = new Vector2D(2.0, 3.0);
            Vector2D vec2 = new Vector2D(4.0, 5.0);

            vec1.NegateX();
            vec1.NegateY();

            vec1.AddVector(4.0,5.0);
            vec1.SubtractVector(vec2);

            vec1.ScalarMultiplication(4.0);
            Console.WriteLine("Magnitude of vector ({0},{1}) is {2:0.000}.", vec1.X, vec1.Y, vec1.GetMagnitude());
            Console.WriteLine("Angle of vector ({0},{1}) is {2:0.000} degrees.", vec1.X, vec1.Y, vec1.GetAngleInDegrees());

            vec1.Normalize();
            Console.WriteLine("Dot product of ({0},{1}) and ({2},{3}) is {4}.", vec1.X, vec1.Y, vec2.X, vec2.Y, vec1.GetDotProduct(vec2));
            Console.WriteLine("Angle between vectors ({0},{1}) and ({2},{3}) is {4:0.000} degrees.", vec1.X, vec1.Y, vec2.X, vec2.Y, vec1.GetAngleBetweenVector(vec2));

            vec1.Lerp((vec2),0.5);
            vec1.RotateVector(55);

            Matrix2x2 m = new Matrix2x2(vec1, vec2);
            m.WriteMatrix();

            m.SetRotationMatrixInDegrees(60.0);
            m.WriteMatrix();

            m.SetScalingMatrix(2.0, 3.0);
            m.WriteMatrix();

            m.SetIdentityMatrix();
            m.WriteMatrix();

            Vector2D vec3 = new Vector2D(5.0, 6.0);
            Vector2D vec4 = new Vector2D(5.0, 9.0);
            Matrix2x2 n = new Matrix2x2(vec3, vec4);

            m.AddMatrix(n);
            m.WriteMatrix();

            m.SubtractMatrix(n);
            m.WriteMatrix();

            Console.WriteLine("Matrix multiplied by matrix n results in:");
            Console.WriteLine("|" + m.MultiplyMatrix(n).Column1.X + " " + m.MultiplyMatrix(n).Column2.X + "|");
            Console.WriteLine("|" + m.MultiplyMatrix(n).Column1.Y + " " + m.MultiplyMatrix(n).Column2.Y + "|");

            m.Transpose();
            m.WriteMatrix();
           



            System.Console.ReadKey();
        }
    }
}
