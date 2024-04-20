

namespace HomeWork8.FirstTask
{
    public interface ICalculable
    {
        public const string _messageArea = "The area is equal to {0}";
        public const string _messagePerimetr = "The perimetr is equal to {0}";
        public double CalculatingArea()
        {
            return 0;
        }

        public double CalculatingPerimeter()
        {
            return 0;
        }
    }
}



/*Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
Реализовать ф-ю подсчета площади для каждого типа фигуры и подсчет
периметра.
Создать массив из 5 фигур.
Вывести на экран сумму периметра всех фигур в массиве.*/