using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_sharp_
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;

       public Triangle()
        {
            Random random = new Random();
            a = random.Next(2, 20);
            Console.WriteLine("a = " + a);
            b = random.Next(2, 20);
            Console.WriteLine("b = " + b);
            c = random.Next(2, 20);
            Console.WriteLine("c = " + c);
        }
        
        public bool isExists()
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }

        public double getAngle1()
        {
            return Math.Acos((a * a + c * c - b * b) / (2 * a * c))*180/Math.PI;              
        }
        public double getAngle2()
        {
            return Math.Acos((a * a + b * b - c * c) / (2 * a * b )) * 180 / Math.PI;
        }
        public double getAngle3()
        {
            return Math.Acos((b * b + c * c - a * a) / (2 * c * b )) * 180 / Math.PI;
        }
        public double getPerimeter()
        {          
          return (a + b + c);           
        }
        public double getSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public void printTriangle()
        {
           
            Console.WriteLine($"Угол A = {String.Format("{0:0.00}", getAngle1())} градусов, Угол В = {String.Format("{0:0.00}", getAngle3())} градусов, Угол C = {String.Format("{0:0.00}", getAngle1())} градусов");
            Console.WriteLine($"P = {String.Format("{0:0.00}", getPerimeter())}cm, S = {String.Format("{0:0.00}", getSquare())}cm^2");
        
        }
    }
}
