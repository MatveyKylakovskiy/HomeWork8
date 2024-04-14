
//First task
/*using HomeWork8.FirstTask;


ICalculable[] figures = { new Triangle(1, 2, 3), new Triangle(1, 1, 1), new Rectangle(4, 4), new Circle(9), new Circle(3) };
double summ = 0;
foreach (var fig in figures)
{
    fig.CalculatingArea();
    summ += fig.CalculatingPerimeter();
    Console.WriteLine();
}
Console.WriteLine($"Summs of perimeters: {summ}");*/

//Second task


using HomeWork8.SecondTask;

var goods = new Goods("bread", 2, new DateTime(2024, 04, 10), 3);
var goods1 = new Goods("beer", 4, new DateTime(2024, 04, 10), 90);
var goods2 = new Goods("potato", 5, new DateTime(2024, 02, 10), 300);

Goods[] prod = { goods1, goods2, goods };


var pak = new Package(prod);
pak.GetInfo();
pak.CheckingExpirationDate();