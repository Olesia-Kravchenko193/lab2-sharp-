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

        public double getArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
