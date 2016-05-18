using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting variables
            double totalTime = 15.5f;   //Total time 
            double a = 2.5f;            //Acceleration
            double Vi = 0f;             //Initial Velocity
            double m = 200f;            //Mass
            double f = m * a;           //Force
            double t = 0.5f;            //Frame Rate 2fps
            double distance = 0;        //Distanced travelled
            double eTime = 0.5f;        //Elapsed time
            Console.WriteLine("T(s)\tForce(N)\tAccel.(m/s2)\tVeloc.(m/s)\tPosition(m)");
            do
            {
                f = m * a;                                                                      //Gets the force
                double Vf = Vi + (a * t);                                                       //Calculates Final velocity in frame
                distance += Vi*t + (.5*(a*(Math.Pow(t,2))));                                    //Calculates Distance
                Console.WriteLine(eTime + "\t" + f + "\t"+ a + "\t" + Vf + "\t" + distance );
              
                Vi = Vf;
                Console.WriteLine();
                eTime += 0.5f;      //Frame rate 
                if (eTime >= 5.5f)
                {
                    a = 0f;         //Change in Acceleraton when elapsed time is equal to 5.5 seconds
                }
                if (eTime >= 10f)
                {
                    a = (-3.125f);  //Change in Acceleration when elapsed time is equal to 10 seconds
                }
                if (Vf <= 0f)
                {
                    a = 0f;         //Change in Acceleration when Final Velocity reaches 0 
                }

               
               
                
            }
                while(eTime != totalTime ); //Exit condition when elapsed time is equal or greater than total time
            Console.ReadKey();
          

        }
    }
}
