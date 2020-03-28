using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_sharp_
{
    class Triangles
    {
        public double side, h, squares, a, b, c;
        public void getTriangles(Triangles[] N_triangles)
        {
            Random r = new Random();
            for (int i = 0; i < N_triangles.Length; i++)
            {
                N_triangles[i] = new Triangles();
                N_triangles[i].side = r.Next(2, 20);
                N_triangles[i].h = r.Next(2, 20);
                N_triangles[i].squares = (N_triangles[i].side * N_triangles[i].h) / 2;
            }
        }
        public void printTriangles(Triangles[] N_triangles)
        {
            for (int i = 0; i < N_triangles.Length; i++)
            {
                Console.WriteLine($"side[{i + 1}] = {N_triangles[i].side}cm, h[{i + 1}] = {N_triangles[i].h}cm");
            }
        }
        public int getMAXsquare(Triangles[] N_triangles)
        {
            int max = 0;
            for (int i = 0; i < N_triangles.Length; i++)
            {
                if (N_triangles[max].squares < N_triangles[i].squares)
                    max = i;
            }
            return max;
        }
        public void printMAXsquare(Triangles[] N_triangles)
        {
            Console.WriteLine($"Максимальную площадь имеет треугольник {getMAXsquare(N_triangles) + 1}");
            Console.WriteLine($"Maximum: side = {N_triangles[getMAXsquare(N_triangles)].side}cm, h = {N_triangles[getMAXsquare(N_triangles)].h}cm, square = {N_triangles[getMAXsquare(N_triangles)].squares}cm^2");
        }





        public void getRight_triangleTriangles(Triangles[] M_triangles)
        {
            Random r = new Random();
            for (int i = 0; i < M_triangles.Length; i++)
            {
                M_triangles[i] = new Triangles();
                M_triangles[i].a = r.Next(2, 20);
                M_triangles[i].b = r.Next(2, 20);
                M_triangles[i].c = Math.Sqrt(M_triangles[i].a * M_triangles[i].a + M_triangles[i].b * M_triangles[i].b);
            }
        }
        public void printRight_triangleTriangles(Triangles[] M_triangles)
        {
            for (int i = 0; i < M_triangles.Length; i++)
            {
                Console.WriteLine($"a[{i + 1}] = {M_triangles[i].a}cm, b[{i + 1}] = {M_triangles[i].b}cm, c[{i + 1}] = {String.Format("{0:0.00}", M_triangles[i].c)}cm");
            }
        }
        public int getMinHypotenuse(Triangles[] M_triangles)
        {
            int min = 0;
            for (int i = 0; i < M_triangles.Length; i++)
            {
                if (M_triangles[min].c > M_triangles[i].c)
                    min = i;
            }
            return min;
        }
        public void printMinHypotenuse(Triangles[] M_triangles)
        {
            Console.WriteLine($"Самую маленькую гипотенузу имеет треугольник {getMinHypotenuse(M_triangles) + 1}");
            Console.WriteLine($"Minimum: c = {String.Format("{0:0.00}", M_triangles[getMinHypotenuse(M_triangles)].c)}cm");
        }
    }
}
