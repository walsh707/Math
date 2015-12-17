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
            Matrix2x2 m = new Matrix2x2(vec1, vec2);
            m.WriteMatrix();

            m.SetRotationMatrixInDegrees(60.0);
            m.WriteMatrix();

            m.SetScalingMatrix(2.0, 3.0);
            m.WriteMatrix();

            m.SetIdentityMatrix();
            m.WriteMatrix();

           //call other functions  such as addmatri()and WriteMatrix(),  SubtractMatrix, multiplication / etc.



            System.Console.ReadKey();
        }
    }
}
