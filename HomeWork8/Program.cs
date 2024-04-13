

using HomeWork8.FirstTask;


ICalculable[] figures = { new Triangle(1, 2, 3), new Triangle(1, 1, 1), new Rectangle(4, 4), new Circle(9), new Circle(3) };
double summ = 0;
foreach (var fig in figures)
{
    fig.CalculatingArea();
    summ += fig.CalculatingPerimeter();
    Console.WriteLine();
}
Console.WriteLine($"Summs of perimeters: {summ}");