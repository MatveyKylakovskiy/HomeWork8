
namespace HomeWork8.SecondTask
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public int ExpirationDate { get; set; }
    }

    public class Goods: Product, IworkingWithData
    {
       public Goods(string name, double price, DateTime productionDate, int expirationDate)
        {
            Name = name;
            Price = price;
            ProductionDate = productionDate;
            ExpirationDate = expirationDate;

        }

        public bool CheckingExpirationDate()
        {   
            TimeSpan timeSpan = (DateTime.Today - ProductionDate);
            int day = timeSpan.Days;
            return day <= ExpirationDate;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Prod date: {ProductionDate}, Exp date: {ExpirationDate}\n");
        }

    }

    public class Batch: Product, IworkingWithData
    {
        public int Quantity { get; set; }
        public Goods _goods;

        public Batch(Goods goods,int quantity)
        {
            Quantity = quantity;
            _goods = goods;
            Name = _goods.Name;
            Price = _goods.Price;
            ProductionDate = _goods.ProductionDate;
            ExpirationDate = _goods.ExpirationDate;
        }

        public bool CheckingExpirationDate()
        {
            TimeSpan timeSpan = (DateTime.Today - ProductionDate);
            int day = timeSpan.Days;
            return day <= ExpirationDate;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Qan: {Quantity}, Price of all {Quantity * Price}\n");
        }

    }

    public class Package:Product, IworkingWithData
    {
        public Goods[] _goods { get; set; }

        public Package(Goods[] goods)
        {
            _goods = goods;
        }

        public void GetInfo()
        {   
            foreach(Goods good in _goods)
            {
                good.GetInfo();
            }
        }

        public bool[] CheckingExpirationDate()
        {
            bool[] check = new bool[_goods.Length];
            
            for(int i = 0; i < check.Length; i++)
            {
                check[i] = _goods[i].CheckingExpirationDate();
                Console.WriteLine($"{_goods[i].Name}: suitable for eating on {DateTime.Today} - {check[i]}\n");
            }

            return check;
        }
    }
}







/*
Полную структуру классов и их взаимосвязь продумать самостоятельно. Исходные
данные база (массив) из n товаров задать непосредственно в коде (захардкодить).
Создать базовый класс Product с методами, позволяющим вывести на экран информацию
о товаре, а также определить, соответствует ли она сроку годности на текущую дату.
Создать производные классы:
Продукт(название, цена, дата производства, срок годности),
Партия(название, цена, количество шт, дата производства, срок годности), Комплект
(названия, цена, перечень продуктов) со своими методами вывода информации на экран,
и определения соответствия сроку годности.
Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, а
также организовать поиск просроченного товара (на момент текущей даты).*/
