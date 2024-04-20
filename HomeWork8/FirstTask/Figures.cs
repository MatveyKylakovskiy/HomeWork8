

namespace HomeWork8.FirstTask
{
    public abstract class Figure
    {
        private ICalculable _calculate;

        public Figure(ICalculable calculate)
        {
            _calculate = calculate;
        }

        public void SetFigure(ICalculable calculate)
        {
            _calculate = calculate;
        }

        public double GetArea()
        {
            return _calculate.CalculatingArea();
        }
        public double GetPerimetr()
        {
            return _calculate.CalculatingPerimeter();
        }

    }
        public class Triangle: ICalculable
        {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public double CalculatingArea()
        {   
            double p = (Side1 + Side2 + Side3) / 2;
            double area = Math.Sqrt(p * (p-Side1) * (p-Side2) * (p-Side3));
            
            if (IsTriangle())
            {
                Console.WriteLine(string.Format(ICalculable._messageArea, area));
                return area;
            }
            else
            {
                Console.WriteLine("The triangle does not exist");
                return 0;
            }
        }

        public double CalculatingPerimeter() 
        {
            
            if (IsTriangle())
            {   
                double prmtr = Side1 + Side2 + Side3;
                Console.WriteLine(string.Format(ICalculable._messagePerimetr, prmtr));
                return prmtr;
            }
            else
            {
                Console.WriteLine("The triangle does not exist");
                return 0;
            }
        }

        public bool IsTriangle()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            double area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            if (area > 0)
            {
                return true;
            }

            return false;
        }
        }

    public class Rectangle: ICalculable
    {
        public double Side1 { get; set;}
        public double Side2 { get; set;}

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public double CalculatingArea()
        {
            double area = Side1 * Side2;
            Console.WriteLine(string.Format(ICalculable._messageArea, area));
            return area;
        }
            public double CalculatingPerimeter()
        {
            double prmtr = Side1 + Side2;
            Console.WriteLine(string.Format(ICalculable._messagePerimetr, prmtr));
            return prmtr;
        }
    }

    public class Circle : ICalculable
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculatingArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine(string.Format(ICalculable._messageArea, area));
            return area;
        }

        public double CalculatingPerimeter()
        {
            double prmtr = 2 * Math.PI * Radius;
            Console.WriteLine(string.Format(ICalculable._messagePerimetr, prmtr));
            return prmtr;

        }
    }
}


/*Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
Реализовать ф-ю подсчета площади для каждого типа фигуры и подсчет
периметра.
Создать массив из 5 фигур.
Вывести на экран сумму периметра всех фигур в массиве.*/