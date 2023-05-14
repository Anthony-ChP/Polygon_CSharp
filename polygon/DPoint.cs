using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
    class DPoint  // Класс точка
    {
        public double x = 0.0;   // Координата х точки
        public double y = 0.0;   // Координата у точки 

        public void Print()     // Вывод координат на экран
        {
            Console.WriteLine($"х: {x}  у: {y}");
        }
        public void CreatePointXY(double xx, double yy)
        {
            x = xx; 
            y = yy;
        }
    }
}
