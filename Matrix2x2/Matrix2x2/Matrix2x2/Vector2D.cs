using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabMatrix2x2
{
    class Vector2D
    {
        private double x;
        private double y;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Vector2D(double xValue, double yValue)
        {
            X = xValue;
            Y = yValue;
        }

        public void SetVector(double xVal, double yVal)
        {
           
        }

        public void AddVector(double xVal, double yVal)
        {
           
        }

        public void SubtractVector(double xVal, double yVal)
        {
          
        }

        public void AddVector(Vector2D vec)
        {
           
        }

        public void SubtractVector(Vector2D vec)
        {
      
        }
    }
}
