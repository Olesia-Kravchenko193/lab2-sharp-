using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_sharp_
{
    class Program
    {     
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
           
            Random random = new Random();
            triangle.a = random.Next(1, 10);
            Console.WriteLine("a = " + triangle.a);
            triangle.b = random.Next(1, 10);
            Console.WriteLine("b = " + triangle.b);
            triangle.c = random.Next(1, 10);
            Console.WriteLine("c = " + triangle.c);

            if (triangle.isExists())
            {
                Console.WriteLine("Треугольник существует");
                Console.WriteLine("Угол А = " + triangle.getAngle1());
                Console.WriteLine("Угол В = " + triangle.getAngle2());
                Console.WriteLine("Угол С = " + triangle.getAngle3());

                Console.WriteLine("P = " + triangle.getPerimeter());
                Console.WriteLine("S = " + triangle.getArea());
            }
            else
                Console.WriteLine("Треугольник НЕ существует");
        }
    }
}