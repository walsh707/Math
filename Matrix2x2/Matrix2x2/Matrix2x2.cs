using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabMatrix2x2
{
    class Matrix2x2
    {
        private Vector2D column1;
        private Vector2D column2;

        public Vector2D Column1
        {
            get
            {
                return column1;
            }
            set
            {
                column1 = value;
            }
        }
        public Vector2D Column2
        {
            get
            {
                return column2;
            }
            set
            {
                column2 = value;
            }
        }

        public Matrix2x2(Vector2D col1, Vector2D col2) 
        {
            Column1 = col1;
            Column2 = col2;
        }

        public Matrix2x2(double e11, double e12, double e21, double e22) 
        {
            Vector2D col1 = new Vector2D(e11, e21);
            Vector2D col2 = new Vector2D(e12, e22);
            Column1 = col1;
            Column2 = col2;

        }

        public void SetMatrix(Vector2D col1, Vector2D col2)
        {
            Column1 = col1;
            Column2 = col2;
        }

        public void SetRotationMatrixInDegrees(double angle)
        {
            angle *= Math.PI / 180.0;
            Vector2D col1 = new Vector2D(Math.Cos(angle), Math.Sin(angle));
            Vector2D col2 = new Vector2D(-Math.Sin(angle), Math.Cos(angle));
            
        }
        public void SetScalingMatrix(double scaleX, double scaleY)
        {
            Vector2D col1 = new Vector2D(scaleX, 0);
            Vector2D col2 = new Vector2D(0, scaleY);
            

        }
        public void SetIdentityMatrix()
        {
            Vector2D col1 = new Vector2D(1.0, 0.0);
            Vector2D col2 = new Vector2D(0.0, 1.0);
            
        }
        public void AddMatrix(Matrix2x2 otherMatrix)
        {
            Vector2D col1 = new Vector2D(this.Column1.X + otherMatrix.Column1.X, this.Column1.Y + otherMatrix.Column1.Y);
            Vector2D col2 = new Vector2D(this.Column2.X + otherMatrix.Column2.X, this.Column2.Y + otherMatrix.Column2.Y);
            
        }
        public void SubtractMatrix(Matrix2x2 otherMatrix)
        {
            Vector2D col1 = new Vector2D(this.Column1.X - otherMatrix.Column1.X, this.Column1.Y - otherMatrix.Column1.Y);
            Vector2D col2 = new Vector2D(this.Column2.X - otherMatrix.Column2.X, this.Column2.Y - otherMatrix.Column2.Y);
            
        }

        public void WriteMatrix()
        {
           
            System.Console.WriteLine("Matrix is:");
            System.Console.WriteLine("|" + this.Column1.X + " " + this.Column2.X + "|");
            System.Console.WriteLine("|" + this.Column1.Y + " " + this.Column2.Y + "|");
        }

        public Matrix2x2 MultiplyMatrix(Matrix2x2 otherMatrix)
        {
            double e11 = 0;
            double e12=0;
            double e21=0;
            double e22=0;
            e11 = this.Column1.X * otherMatrix.Column1.X + this.Column2.X * otherMatrix.Column1.Y;
            e12 = this.Column1.X * otherMatrix.Column2.X + this.Column2.X * otherMatrix.Column2.Y;
            e21 = this.Column1.Y * otherMatrix.Column1.X + this.Column2.Y * otherMatrix.Column1.Y;
            e22 = this.Column1.Y * otherMatrix.Column2.X + this.Column2.Y * otherMatrix.Column2.Y;

            Matrix2x2 newMatrix = new Matrix2x2(e11, e12, e21, e22);
            return newMatrix;
        }

        public void Transpose()
        {
            Vector2D col1 = new Vector2D(this.Column1.X, this.Column2.X);
            Vector2D col2 = new Vector2D(this.Column1.Y, this.Column2.Y);
            this.SetMatrix(col1, col2);
          
        }
        
        
    }
}
