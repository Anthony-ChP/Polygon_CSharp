using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{


    class DPolygon

    {

        double DPointDistance(int a, int b)  // Расстояние между вершинами с индексами a b многоугольника. 
        {                                    // Квадратный корень из суммы квадратов разностей соответствующих координат
            double result;
            result = Math.Sqrt((DVertexes[a].x - DVertexes[b].x) * (DVertexes[a].x - DVertexes[b].x) + (DVertexes[a].y - DVertexes[b].y) * (DVertexes[a].y - DVertexes[b].y));
            return result;
        }

        DPoint[] DVertexes = new DPoint[0];// вершины храним в массиве. тип элементов - точка(DPoint)

        public double DPerimeter()  // Периметр многоугольника
        {
            double result = 0;
            for (int i = 1; i < DVertexes.Length; i++)
            {
                result += DPointDistance(i - 1, i);
            }
            result += DPointDistance(DVertexes.Length - 1, 0);
            return result;
        }

        public double DSquare()  // Площадь многоугольника. Считается как сумма площадей треугольников, на которые разбивается многоугольник
        {
            double result = 0;
            int i;


            if (DVertexes.Length >= 3)
            {
                for (i = 2; i < DVertexes.Length; i++)
                {
                    result += DGeron(DPointDistance(0, i - 1), DPointDistance(i - 1, i), DPointDistance(i, 0));
                }
            }

            return result;
        }
        static double DGeron(double a, double b, double c) // Площадь треугольника вычисляется по формуле Герона
        {
            double p, result;

            p = (a + b + c) / 2;
            result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            return result;
        }
        public void DAddVertex(double x, double y) //Добавление новой вершины. Увеличиваем количество вершин на 1 и последней в массив вершин записываем точку, переданную параметром
        {                                         //Если вершин еще нет, то инициализируем массив вершин и добавляем в него точку
            Array.Resize(ref DVertexes, DVertexes.Length + 1);
            DVertexes[DVertexes.Length - 1] = new DPoint(x, y);                

        }

        public void DPolygonPrint()   // Вывод координат вершин многоугольгика на экран
        {
            Console.WriteLine("Vertexes:");
            for (int i = 0; i < DVertexes.Length; i++)
            {
                DVertexes[i].Print();
            }
            Console.WriteLine("___________");

        }
    }
}
