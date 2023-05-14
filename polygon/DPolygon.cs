using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{


    class DPolygon

    {

        double DPointDistance(int a, int b)  // Раастояние между вершинами с индексами a b многоугольника
        {
            double result;
            result = Math.Sqrt((DVertexes[a].x - DVertexes[b].x) * (DVertexes[a].x - DVertexes[b].x) + (DVertexes[a].y - DVertexes[b].y) * (DVertexes[a].y - DVertexes[b].y));
            /*// Debug strings
            Console.WriteLine($"Points {a}, {b}");
            Console.WriteLine($"a.x = {DVertexes[a].x}, a.y = {DVertexes[a].y}");
            Console.WriteLine($"b.x = {DVertexes[b].x}, b.y = {DVertexes[b].y}");
            Console.WriteLine($"[a,b] = {result}");
            Console.WriteLine("---------------------------------");
            // _____________
           */

            return result;
        }

        DPoint[] DVertexes = new DPoint[0];// вершины 

        public double DPerimeter()  // Периметр многоугольника
        {
            double result = 0;
            for (int i = 1; i < DVertexes.Length; i++)
            {
                result += DPointDistance(i - 1, i);
                // Debug strings
                Console.WriteLine($"[{i-1}, {i}] = {result}");
                Console.WriteLine("----------------------------------------------");
                //-------------------
            }
            result += DPointDistance(DVertexes.Length - 1, 0);
            return result;
        }

        public void DAddVertex(DPoint PointToAdd) //Добавление новой вершины. Увеличиваем количество вершин на 1 и последнец в массив вершин записываем точку, переданную параметром
        {             //Если вершин еще нет, то инициализируем массив вершин и добавляем в него точку


            if (DVertexes.Length == 0)
            {
                DVertexes = new DPoint[1];
                DVertexes[0] = new DPoint();
                DVertexes[0].x = PointToAdd.x;
                DVertexes[0].y = PointToAdd.y;

                // Debug strings
                Console.WriteLine("First vertex:");
                DVertexes[0].Print();
                Console.WriteLine("------------------------------------------");
                //--------------
            }
            else
            {
                Array.Resize(ref DVertexes, DVertexes.Length + 1);
                DVertexes[DVertexes.Length - 1] = new DPoint();
                DVertexes[DVertexes.Length - 1].x = PointToAdd.x;
                DVertexes[DVertexes.Length - 1].y = PointToAdd.y;
                
                // Debug Strings
                Console.WriteLine("Point to add:");
                DVertexes[DVertexes.Length - 1].Print();
                Console.WriteLine("Number of Vertexes:");
                Console.WriteLine(DVertexes.Length);
                Console.WriteLine("--------------------------------");
                //--------------

            }
        }

        public void DPolygonPrint()
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
