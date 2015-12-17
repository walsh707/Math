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

        public void NegateX()
        {
            double newX = -1 * this.X; 
            Console.WriteLine("new Vector is ({0},{1})", newX, Y);
        }

        public void NegateY()
        {
            double newY = -1 * this.Y; 
            Console.WriteLine("New vector is ({0},{1})", X, newY);
        }

        public void AddVector(double xVal, double yVal)
        {
            double xadd = this.X + xVal; // Add both X components together
            double yadd = this.Y + yVal; // Add both Y compenents together
            Console.WriteLine("Sum of the vectors ({0},{1}) and ({2},{3}) is:", this.X, this.Y, xVal, yVal);
            Console.WriteLine("({0},{1})", xadd, yadd);
        }

        public void SubtractVector(double xVal, double yVal)
        {
            double xsub = this.X - xVal; // Subtract both X components
            double ysub = this.Y - yVal; // Subtract both X components
            Console.WriteLine("Result of subtracting vectors ({0},{1}) by ({2},{3}) is:", this.X, this.Y, xVal, yVal);
            Console.WriteLine("({0},{1})", xsub, ysub); 
        }

        public void AddVector(Vector2D vec) // Method uses vector object as input. So use member accessor . to accessor the X and Y components of new vector object
        {
            double xadd = this.X + vec.X; //similar to before
            double yadd = this.Y + vec.Y;
            Console.WriteLine("Sum of the vectors ({0},{1}) and ({2},{3}) is:", this.X, this.Y, vec.X, vec.Y);
            Console.WriteLine("({0},{1})", xadd, yadd);
        }

        public void SubtractVector(Vector2D vec) // Same as above except subtract
        {
            double xsub = this.X - vec.X;
            double ysub = this.Y - vec.Y;
            Console.WriteLine("Result of subtracting vectors ({0},{1}) by ({2},{3}) is:", this.X, this.Y, vec.X, vec.Y);
            Console.WriteLine("({0},{1})", xsub, ysub);
        }

        public void ScalarMultiplication(double scalar) // Multiply scalar value by each X and Y to get new X and Y
        {
            double xScale = scalar * this.X; 
            double yScale = scalar * this.Y;
            Console.WriteLine("Vector ({0},{1}) scaled by a factor of {2}:", this.X, this.Y, scalar);
            Console.WriteLine("({0},{1})", xScale, yScale);
        }

        public double GetMagnitude()
        {
            double x2 = this.X * this.X; // Square both the X and Y components
            double y2 = this.Y * this.Y;
            double sumx2y2 = x2 + y2; // Add the squared X and Y components
            double r = Math.Sqrt(sumx2y2); // Takes the square root of the sum to get magnitude r
            return r;
        }

        public double GetAngleInDegrees()
        {
            double thetarad = Math.Atan2(this.Y, this.X); // Use arctan function Math class to solve for angle
            double theta = thetarad * (180 / Math.PI);  //The Math class library uses radians so convert to degrees.
            return theta; 
        }

        public void Normalize()
        {
            double xNorm = this.X / GetMagnitude(); // Divide each X and Y component by the magnitude to get the normalized vector
            double yNorm = this.Y / GetMagnitude();
            Console.WriteLine("Vector ({0},{1}) normalized results in:", this.X, this.Y);
            Console.WriteLine("({0:0.000},{1:0.000})", xNorm, yNorm); // Displayed output to 3 significant digits. the 0.000 means 3 significant digits
        }

        public double GetDotProduct(Vector2D otherVector) // Method requires vector object input
        {
            double dot = (this.X * otherVector.X) + (this.Y * otherVector.Y); // Simple dot product. Uses given vector and defined vector to get dot product
            return dot;
        }

        public double GetAngleBetweenVector(Vector2D otherVector)
        {
            double magA = GetMagnitude(); // Need magnitudes of both vectors and dot product to solve for angle
            double magB = otherVector.GetMagnitude();
            double dot = GetDotProduct(otherVector);
            double theta = (Math.Acos((dot / (magA * magB)))) * (180 / Math.PI); // Formula rearranged to solve for angle and converted to degrees from radians
            return theta;
        }

        public void Lerp(Vector2D otherVector, double t)
        {
            double xLerp = ((1 - t) * this.X) + (t * otherVector.X); // Use Lerp formula to solve for new X and Y values. t must be between 0 and 1.
            double yLerp = ((1 - t) * this.Y) + (t * otherVector.Y);
            Console.WriteLine("t = {0}, the vector in between ({1},{2}) and ({3},{4}) is at:", t, this.X, this.Y, otherVector.X, otherVector.Y);
            Console.WriteLine("({0},{1})", xLerp, yLerp); // t=0 results in vector A while t=1 results in vector B. 0<t<1 produces new vector between A and B
        }

        public void RotateVector(double angle)
        {
            double angleRads = angle * (Math.PI / 180); // Convert angle to radians because Math functions in class library uses radians, not degrees
            double xRotate = (this.X * Math.Cos(angleRads)) - (this.Y * Math.Sin(angleRads)); // Substitute values in both formulas to get new X and Y
            double yRotate = (this.X * Math.Sin(angleRads)) + (this.Y * Math.Cos(angleRads));
            Console.WriteLine("Vector ({0},{1}) rotated by {2} degrees results in new vector:", this.X, this.Y, angle);
            Console.WriteLine("({0:0.000},{1:0.000})", xRotate, yRotate); // New vector displayed to 3 significant digits
        }
    }
}
