using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1
{
    class Rectangle
    {
        // создаём в классе Rectangle приватные поля: side1 и side2
        private double side1, side2;

        //создаём пользовательский конструктор Rectangle(double side1, double side2)
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // создаём метод AreaCalculator()
        private double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        //создвём метод PerimetrCalulator()
        private double PerimetrCalculator()
        {
           double perimetr = (side1 * 2) + (side2 * 2);
           return perimetr;
        }

        // создаём свойство double Area
        public double Area
        {
            get { return AreaCalculator(); }
        }

        // создаём свойство double Perimetr
        public double Perimetr
        {
            get { return PerimetrCalculator(); }
        }
    }
}
