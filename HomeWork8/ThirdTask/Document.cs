
using HomeWork8.SecondTask;
using System.Xml.Linq;

namespace HomeWork8.ThirdTask
{
    public abstract class Document
    {
        private int _numberOfDoc;
        public int NumberOfDoc
        {
            get { return _numberOfDoc; }
            set { _numberOfDoc = value; }
        }

        private DateTime _dateOfDoc;
        public DateTime DateOfDoc
        {
            get { return _dateOfDoc; }
            set { _dateOfDoc = value; }
        }

        public abstract void GetInfo();
        
    }

    public class ProductContract: Document
    {
        private string _typeOfProduct;
        private int _quantity;

        public ProductContract(int numberOfDoc, DateTime dateOfDoc, string typeOfProduct, int quantity)
        {   
            NumberOfDoc = numberOfDoc;
            DateOfDoc = dateOfDoc;
            _typeOfProduct = typeOfProduct;
            _quantity = quantity;
        }

        public ProductContract()
        {

        }
        public override void GetInfo()
        {
            Console.WriteLine($"Type of Doc: ProductContract, Numb of Doc: {NumberOfDoc}, Date of Doc: {DateOfDoc}, Type Of Prod: {_typeOfProduct}, Quantity: {_quantity}");
        }
    }

    public class EmployeeContract(): Document
    {
        private DateTime _dateOfEnd;
        private string _employeName;

        public EmployeeContract(int numberOfDoc, DateTime dateOfDoc, DateTime dateOfEnd, string employeName): this()
        {
            NumberOfDoc= numberOfDoc;
            DateOfDoc = dateOfDoc;
            _dateOfEnd = dateOfEnd;
            _employeName = employeName;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Type of Doc: EmployeeContract, Numb of Doc: {NumberOfDoc}, Date of Doc: {DateOfDoc}, Date of end: {_dateOfEnd}, Employer Name: {_employeName}");
        }
    }

    public class FinancialInvoice(): Document
    {
        private double _monthlySum;
        private int _codeOfDprt;

        public FinancialInvoice(int numberOfDoc, DateTime dateOfDoc, double monthlySum, int codeOfDprt): this()
        {
            NumberOfDoc = numberOfDoc;
            DateOfDoc = dateOfDoc;
            _monthlySum = monthlySum;
            _codeOfDprt = codeOfDprt;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Type of Doc: FinancialInvoice, Numb of Doc: {NumberOfDoc}, Date of Doc: {DateOfDoc}, MonthlySum: {_monthlySum}, Code of Dprt: {_codeOfDprt}");
        }
    }
}




/*3.Создать систему для учета документов.
Создать класс Регистр, который будет иметь методы: сохранения документа в регистре, предоставление информации о документе
Система может работать с тремя типами документов:

1.Контракт на поставку товаров
Содержит поля:
Номер документа
Тип товаров
Количество товаров
Дата документа

2. Контракт с сотрудником
Содержит поля:
Номер документа
Дата документа
Дата окончания контракта
Имя сотрудника

3. Финансовая накладная
Содержит поля:
Итоговая сумма за месяц
Дата документа
Номер документа
Код департамента

Класс регистр должен содержать внутри себя массив и при добавлении
документа в регистр этот добавляемый документ должен добавляться в массив;

Массив для класса регистра должен быть размером 10;

Для полей "Дата документа" следует использовать тип данных Date;

В методе предоставления информации о документе следует выводить на экран
информацию о переданном входным параметром документе;

Каждый класс для описания документов должен содержать конструктор с
параметрами и без;

Для имитации работы системы создайте класс Main, который будет содержать
только один метод public static void main
В этом методе напишите код для создания каждого из типов документов,
добавления их в регистр и вывода информации о документе;

Все классы разместить по пакетам;

При выполнении задания использовать понятия интерфейсов и абстрактных
классов.*/