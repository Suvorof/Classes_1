using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа для расчёта площади прямоугольника и его периметра");
            Console.WriteLine("Введите длину первой стороны прямоугольника в сантиметрах");
            string a = Console.ReadLine();
            double storona1 = Convert.ToDouble(a);

            Console.WriteLine("Введите длину второй стороны прямоугольника в сантиметрах");
            string b = Console.ReadLine();
            double storona2 = Convert.ToDouble(b);

            Rectangle my_rectangle = new Rectangle(storona1, storona2);
            Console.WriteLine("Площадь прямоугольника равна {0} квадратных сантиметров", my_rectangle.Area);
            Console.WriteLine("Периметр прямоугольника равен {0} см", my_rectangle.Perimetr);
            Console.ReadKey();
        }
    }
}
