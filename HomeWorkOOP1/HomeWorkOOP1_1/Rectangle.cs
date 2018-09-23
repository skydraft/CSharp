using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP1_1
{
    class Rectangle
    {
       private double side1;
       private double side2;
        private double area;
        private double perimetr;
        //пользовательский конструктор
        public Rectangle(double side1, double side2)
        {
            
            this.side1 = side1;
            this.side2 = side2;

        }
        public Rectangle()
        {
            side1 = 5;
            side2 = 10;
             
        }
        //площадь прямоугольника
        private double AreaCalculator()
        {
            double area = side1 * side2;
            return area;

        }
        //периметер прямоугольника
        private double PerimeterCalculator()
        {
            double perimeter = 2* ( side1 +side2);
            return perimeter;
        }
        public double Area
        {
            get
            {
                
                this.area = AreaCalculator();
                return area;
            }
        }
        public double Perimeter
        {
            get
            {
                
                this.perimetr = PerimeterCalculator();
                return perimetr;
            }
        }

    }
}
