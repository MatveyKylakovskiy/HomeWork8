
namespace HomeWork8.ThirdTask
{
    public class Main
    {
        public static void main()
        {
            Document[] docs =
            
            { 
                
            new ProductContract(1,new DateTime(2024, 01, 15), "prod1", 4),
            new ProductContract(2,new DateTime(2024, 02, 28), "prod2", 8),
            new ProductContract(3,new DateTime(2024, 03, 01), "prod3", 16),
            new EmployeeContract(4,new DateTime(2020, 05, 12), new DateTime(2025, 05, 12), "Bob"),
            new EmployeeContract(5,new DateTime(2015, 06, 25), new DateTime(2020, 06, 25), "Jack"),
            new EmployeeContract(6,new DateTime(2025, 07, 23), new DateTime(2030, 07, 23), "Steve"),
            new FinancialInvoice(7,DateTime.Now, 1420, 5),
            new FinancialInvoice(8,DateTime.Now, 25286.2, 5),
            new FinancialInvoice(9,DateTime.Now, 534.533, 5),
            new FinancialInvoice(10,DateTime.Now, 22222, 6),
            new FinancialInvoice(11,DateTime.Now, 5354343, 7),
            new FinancialInvoice(12, DateTime.Now, 7005808, 9)

            };

            var registor = new Registor();
            int counter = 0;
            bool check = true;

            while (check)
            {
                check = registor.AddNewDoc(docs[counter]);
                counter++;
            }


            Console.WriteLine();
            registor.GetInfo();
        }
    }
}
