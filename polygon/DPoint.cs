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

        public void Print()     // Вывод координат точки на экран
        {
            Console.WriteLine($"х: {x}  у: {y}");
        }
        public void CreatePointXY(double xx, double yy)
        {
            x = xx; 
            y = yy;
        }

        public DPoint() // Если в конструктор не передать параметры, то новая точка получает координаты (0,0)
        {
            x = 0.0;
            y = 0.0;
        }

        public DPoint(double x, double y) // конструктор с переданными в него параметрами - координатами. Новая получает координаты (х,у) 
        {
            this.x = x;
            this.y = y;
        }
    }
}
