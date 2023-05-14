using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{


    class DPolygon

    {

        double DPointDistance(int a, int b)  // Раастояние между вершинами с индексами a b многоугольника. 
        {                                    // Квадратный корень из суммы квадратов разностей соответствующих координат
            double result;
            result = Math.Sqrt((DVertexes[a].x - DVertexes[b].x) * (DVertexes[a].x - DVertexes[b].x) + (DVertexes[a].y - DVertexes[b].y) * (DVertexes[a].y - DVertexes[b].y));
            return result;
        }

        DPoint[] DVertexes = new DPoint[0];// вершины 

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

        public void DAddVertex(DPoint PointToAdd) //Добавление новой вершины. Увеличиваем количество вершин на 1 и последней в массив вершин записываем точку, переданную параметром
        {                                         //Если вершин еще нет, то инициализируем массив вершин и добавляем в него точку


            if (DVertexes.Length == 0)
            {
                DVertexes = new DPoint[1];
                DVertexes[0] = new DPoint();
                DVertexes[0].x = PointToAdd.x;
                DVertexes[0].y = PointToAdd.y;
            }
            else
            {
                Array.Resize(ref DVertexes, DVertexes.Length + 1);
                DVertexes[DVertexes.Length - 1] = new DPoint();
                DVertexes[DVertexes.Length - 1].x = PointToAdd.x;
                DVertexes[DVertexes.Length - 1].y = PointToAdd.y;
            }
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
