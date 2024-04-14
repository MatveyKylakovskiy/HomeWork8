
namespace HomeWork8.SecondTask
{
    public abstract class Product
    {
        public string _name;
        public double _price;
        public DateTime _productionDate;
        public int _expirationDate;
    }

    public class Goods: Product, IworkingWithData
    {
       public Goods(string name, double price, DateTime productionDate, int expirationDate)
        {
            _name = name;
            _price = price;
            _productionDate = productionDate;
            _expirationDate = expirationDate;

        }

        public bool CheckingExpirationDate()
        {   
            TimeSpan timeSpan = (DateTime.Today - _productionDate);
            int day = timeSpan.Days;
            return day <= _expirationDate;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name}, Price: {_price}, Prod date: {_productionDate}, Exp date: {_expirationDate}\n");
        }

    }

    public class Batch: Product, IworkingWithData
    {
        public int _quantity;
        public Goods _goods;

        public Batch(Goods goods,int quantity)
        {
            _quantity = quantity;
            _goods = goods;
            _name = _goods._name;
            _price = _goods._price;
            _productionDate = _goods._productionDate;
            _expirationDate = _goods._expirationDate;
        }

        public bool CheckingExpirationDate()
        {
            TimeSpan timeSpan = (DateTime.Today - _productionDate);
            int day = timeSpan.Days;
            return day <= _expirationDate;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name}, Qan: {_quantity}, Price of all {_quantity * _price}\n");
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
                Console.WriteLine($"{_goods[i]._name}: suitable for eating on {DateTime.Today} - {check[i]}\n");
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
