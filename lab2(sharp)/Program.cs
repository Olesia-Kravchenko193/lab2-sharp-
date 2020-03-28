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
            
            if (triangle.isExists())
            {
                Console.WriteLine("Треугольник существует");
                triangle.printTriangle();
            }
            else
                Console.WriteLine("Треугольник НЕ существует");

            Right_triangle rightTriangle = new Right_triangle();
            if (rightTriangle.isExists())
            {
                if(rightTriangle.getRight_triangle())
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник НЕ прямоугольный");
                Console.WriteLine("Треугольник существует");
                rightTriangle.printTriangle();
            }
            else
                Console.WriteLine("Треугольник НЕ существует");
            

            
            Console.WriteLine("ВВедите кол-во (N) треугольников: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Triangles[] N_triangles = new Triangles[N];

            Console.WriteLine("ВВедите кол-во (М) прямоугольных треугольников: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Triangles[] M_triangles = new Triangles[M];

            Triangles triangles = new Triangles();
            triangles.getTriangles(N_triangles);
            triangles.printTriangles(N_triangles);
            triangles.printMAXsquare(N_triangles);
            Console.WriteLine();
            triangles.getRight_triangleTriangles(M_triangles);
            triangles.printRight_triangleTriangles(M_triangles);
            triangles.printMinHypotenuse(M_triangles);
            Console.WriteLine();
        }
    }

    class Right_triangle : Triangle
    {
        public bool getRight_triangle()
        {
            if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                return true;
            else
                return false;
        }
    }
}

